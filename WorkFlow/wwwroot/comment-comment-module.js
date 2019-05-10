(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["comment-comment-module"],{

/***/ "./src/app/comment/comment.module.ts":
/*!*******************************************!*\
  !*** ./src/app/comment/comment.module.ts ***!
  \*******************************************/
/*! exports provided: CommentPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CommentPageModule", function() { return CommentPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _comment_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./comment.page */ "./src/app/comment/comment.page.ts");







var routes = [
    {
        path: '',
        component: _comment_page__WEBPACK_IMPORTED_MODULE_6__["CommentPage"]
    }
];
var CommentPageModule = /** @class */ (function () {
    function CommentPageModule() {
    }
    CommentPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_comment_page__WEBPACK_IMPORTED_MODULE_6__["CommentPage"]]
        })
    ], CommentPageModule);
    return CommentPageModule;
}());



/***/ }),

/***/ "./src/app/comment/comment.page.html":
/*!*******************************************!*\
  !*** ./src/app/comment/comment.page.html ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\n  <ion-toolbar>\n    <ion-title>Comment</ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content padding>\n    <div class=\"col s12 m4\">\n        <form (ngSubmit)=\"onSubmit(projectForm)\" #projectForm=\"ngForm\">\n          <ion-grid>\n            <ion-row justify-content-center>\n              <ion-col align-self-center size-md=\"6\" size-lg=\"5\" size-xs=\"12\">\n                <div text-center *ngIf=\"isMatch(['Manager'])\">                  \n                  <h4>Project form </h4>\n                </div>\n                <div padding>\n                  <input type=\"hidden\" name=\"ID\" #ID=\"ngModel\" [(ngModel)]=\"\">\n                  <ion-textarea [(ngModel)]=\"message\" type=\"text\" placeholder=\"Comment .... \"></ion-textarea>\n                  \n                </div>\n                <div padding>\n                  <ion-button color=\"light\" size=\"default\" type=\"submit\" expand=\"block\">Send</ion-button>\n                  <ion-button color=\"dark\" size=\"default\" type=\"button\" expand=\"block\" (click)=\"resetForm(projectForm)\">\n                    Reset\n                  </ion-button>\n                </div>\n              </ion-col>\n            </ion-row>\n          </ion-grid>\n        </form>\n      </div>\n  <ion-footer padding>\n    \n    <ion-button color=\"primary\" size=\"default\" type=\"submit\" float-right (click)=\"sendComment()\">Send</ion-button>\n  </ion-footer>\n</ion-content>\n"

/***/ }),

/***/ "./src/app/comment/comment.page.scss":
/*!*******************************************!*\
  !*** ./src/app/comment/comment.page.scss ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2NvbW1lbnQvY29tbWVudC5wYWdlLnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/comment/comment.page.ts":
/*!*****************************************!*\
  !*** ./src/app/comment/comment.page.ts ***!
  \*****************************************/
/*! exports provided: CommentPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CommentPage", function() { return CommentPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var CommentPage = /** @class */ (function () {
    function CommentPage() {
    }
    CommentPage.prototype.ngOnInit = function () {
    };
    CommentPage.prototype.sendComment = function () {
        console.log("Comment sended!...");
    };
    CommentPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-comment',
            template: __webpack_require__(/*! ./comment.page.html */ "./src/app/comment/comment.page.html"),
            styles: [__webpack_require__(/*! ./comment.page.scss */ "./src/app/comment/comment.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], CommentPage);
    return CommentPage;
}());



/***/ })

}]);
//# sourceMappingURL=comment-comment-module.js.map