'use strict';
var yeoman = require('yeoman-generator');
var chalk = require('chalk');
var yosay = require('yosay');
var cp = require('child_process');

module.exports = yeoman.Base.extend({
  prompting: function () {
    this.log(yosay(
      'Welcome to the ' + chalk.green('ASP.NET Core') + ' generator!'
    ));

    var spawnOptions = {
      cwd: this.destinationRoot(),
      stdio: ['ignore', 'inherit', 'inherit'],
    };

    this.spawn = function (cmd, args, callback) {
      cp.spawn(cmd, args, spawnOptions).on('close', function (code) {
        if (code === 0) {
          callback();
        } else {
          callback(new Error(cmd + ' ' + args.join(' ') + ' => ' + code + ' (error)'));
        }
      });
    };
  },

  clonning: function () {
    var done = this.async();
    this.spawn('git', [
      'clone', '-o', 'aspnet-starter-kit', '-b', 'master', '--single-branch',
      'https://github.com/kriasoft/aspnet-starter-kit.git', this.destinationRoot()], done);
  },

  install: function () {
    this.installDependencies();
  },

  dotnetRestore: function () {
    var done = this.async();
    this.spawn('dotnet', ['restore'], done);
  },
});
