(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["invite-link-invite-link-module"],{

/***/ "./src/app/invite-link/invite-link.module.ts":
/*!***************************************************!*\
  !*** ./src/app/invite-link/invite-link.module.ts ***!
  \***************************************************/
/*! exports provided: InviteLinkPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "InviteLinkPageModule", function() { return InviteLinkPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _invite_link_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./invite-link.page */ "./src/app/invite-link/invite-link.page.ts");







var routes = [
    {
        path: '',
        component: _invite_link_page__WEBPACK_IMPORTED_MODULE_6__["InviteLinkPage"]
    }
];
var InviteLinkPageModule = /** @class */ (function () {
    function InviteLinkPageModule() {
    }
    InviteLinkPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_invite_link_page__WEBPACK_IMPORTED_MODULE_6__["InviteLinkPage"]]
        })
    ], InviteLinkPageModule);
    return InviteLinkPageModule;
}());



/***/ }),

/***/ "./src/app/invite-link/invite-link.page.html":
/*!***************************************************!*\
  !*** ./src/app/invite-link/invite-link.page.html ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n<ion-content padding>\n    <ion-grid style=\"height: 100%\">\n        <ion-row justify-content-center align-items-center style=\"height: 100%\">      \n            <ion-col align-self-center size-md=\"4\" size-lg=\"4\" size-xs=\"12\">\n              <ion-card id = \"login-card\" color=\"light shade\">\n                  <ion-item>                    \n                    <ion-input type='text' value=\"{{ this.projectService.link }}\" readonly></ion-input>\n                    <ion-label position=\"stacked\" style=\"text-align: center;\">\n                        <ion-button size=\"default\" (click)=\"copy()\" color=\"dark\">\n                          Копировать\n                        </ion-button>\n                      </ion-label>\n                  </ion-item>                                                \n              </ion-card>\n            </ion-col>            \n        </ion-row>\n      </ion-grid>\n</ion-content>\n"

/***/ }),

/***/ "./src/app/invite-link/invite-link.page.scss":
/*!***************************************************!*\
  !*** ./src/app/invite-link/invite-link.page.scss ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2ludml0ZS1saW5rL2ludml0ZS1saW5rLnBhZ2Uuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/invite-link/invite-link.page.ts":
/*!*************************************************!*\
  !*** ./src/app/invite-link/invite-link.page.ts ***!
  \*************************************************/
/*! exports provided: InviteLinkPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "InviteLinkPage", function() { return InviteLinkPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_project_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../shared/project.service */ "./src/app/shared/project.service.ts");
/* harmony import */ var _ionic_native_clipboard_ngx__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @ionic-native/clipboard/ngx */ "./node_modules/@ionic-native/clipboard/ngx/index.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");





var InviteLinkPage = /** @class */ (function () {
    function InviteLinkPage(projectService, clipboard, toastController) {
        this.projectService = projectService;
        this.clipboard = clipboard;
        this.toastController = toastController;
    }
    InviteLinkPage.prototype.ngOnInit = function () {
    };
    InviteLinkPage.prototype.presentToast = function (text, theme) {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
            var toast;
            return tslib__WEBPACK_IMPORTED_MODULE_0__["__generator"](this, function (_a) {
                switch (_a.label) {
                    case 0: return [4 /*yield*/, this.toastController.create({
                            message: text,
                            showCloseButton: true,
                            duration: 2000,
                            position: 'top',
                            closeButtonText: 'Done',
                            color: theme
                        })];
                    case 1:
                        toast = _a.sent();
                        toast.present();
                        return [2 /*return*/];
                }
            });
        });
    };
    InviteLinkPage.prototype.copy = function () {
        var selBox = document.createElement('textarea');
        selBox.style.position = 'fixed';
        selBox.style.left = '0';
        selBox.style.top = '0';
        selBox.style.opacity = '0';
        selBox.value = this.projectService.link.toString();
        document.body.appendChild(selBox);
        selBox.focus();
        selBox.select();
        document.execCommand('copy');
        document.body.removeChild(selBox);
        this.clipboard.copy(this.projectService.link.toString());
        this.presentToast('Ссылка скопирована', 'dark');
    };
    InviteLinkPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-invite-link',
            template: __webpack_require__(/*! ./invite-link.page.html */ "./src/app/invite-link/invite-link.page.html"),
            styles: [__webpack_require__(/*! ./invite-link.page.scss */ "./src/app/invite-link/invite-link.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_project_service__WEBPACK_IMPORTED_MODULE_2__["ProjectService"],
            _ionic_native_clipboard_ngx__WEBPACK_IMPORTED_MODULE_3__["Clipboard"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["ToastController"]])
    ], InviteLinkPage);
    return InviteLinkPage;
}());



/***/ })

}]);
//# sourceMappingURL=invite-link-invite-link-module.js.map