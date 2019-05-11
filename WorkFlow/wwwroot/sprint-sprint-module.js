(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["sprint-sprint-module"],{

/***/ "./src/app/sprint/sprint.module.ts":
/*!*****************************************!*\
  !*** ./src/app/sprint/sprint.module.ts ***!
  \*****************************************/
/*! exports provided: SprintPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SprintPageModule", function() { return SprintPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _sprint_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./sprint.page */ "./src/app/sprint/sprint.page.ts");







var routes = [
    {
        path: '',
        component: _sprint_page__WEBPACK_IMPORTED_MODULE_6__["SprintPage"]
    }
];
var SprintPageModule = /** @class */ (function () {
    function SprintPageModule() {
    }
    SprintPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_sprint_page__WEBPACK_IMPORTED_MODULE_6__["SprintPage"]]
        })
    ], SprintPageModule);
    return SprintPageModule;
}());



/***/ }),

/***/ "./src/app/sprint/sprint.page.html":
/*!*****************************************!*\
  !*** ./src/app/sprint/sprint.page.html ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\n  <ion-toolbar>\n    <ion-title>sprint</ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content padding>\n\n</ion-content>\n"

/***/ }),

/***/ "./src/app/sprint/sprint.page.scss":
/*!*****************************************!*\
  !*** ./src/app/sprint/sprint.page.scss ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NwcmludC9zcHJpbnQucGFnZS5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/sprint/sprint.page.ts":
/*!***************************************!*\
  !*** ./src/app/sprint/sprint.page.ts ***!
  \***************************************/
/*! exports provided: SprintPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SprintPage", function() { return SprintPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var SprintPage = /** @class */ (function () {
    function SprintPage() {
    }
    SprintPage.prototype.ngOnInit = function () {
    };
    SprintPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-sprint',
            template: __webpack_require__(/*! ./sprint.page.html */ "./src/app/sprint/sprint.page.html"),
            styles: [__webpack_require__(/*! ./sprint.page.scss */ "./src/app/sprint/sprint.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], SprintPage);
    return SprintPage;
}());



/***/ })

}]);
//# sourceMappingURL=sprint-sprint-module.js.map