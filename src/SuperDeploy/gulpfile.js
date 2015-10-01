/// <binding Clean='clean' />
'use strict';
var gulp = require("gulp"),
  rimraf = require("rimraf"),
  concat = require("gulp-concat"),
  cssmin = require("gulp-cssmin"),
  uglify = require("gulp-uglify"),
  project = require("./project.json");
var sass = require("gulp-sass");
var bowerFiles = require("bower-files")();


var paths = {
  webroot: "./" + project.webroot + "/"
};

paths.js = paths.webroot + "js/";
paths.css = paths.webroot + "css/";

gulp.task("styles", function () {
  gulp.src("Static/styles/style.scss")
    .pipe(sass())
    .pipe(gulp.dest(paths.css));
});

gulp.task("libs", function () {
  return gulp.src(bowerFiles.ext("js").files)
    .pipe(concat('vendor.js'))
    .pipe(gulp.dest(paths.js));
});

gulp.task("default", ["styles", "libs"])