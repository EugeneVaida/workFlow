(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["users-users-module"],{

/***/ "./src/app/users/users.module.ts":
/*!***************************************!*\
  !*** ./src/app/users/users.module.ts ***!
  \***************************************/
/*! exports provided: UsersPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UsersPageModule", function() { return UsersPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _users_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./users.page */ "./src/app/users/users.page.ts");







var routes = [
    {
        path: '',
        component: _users_page__WEBPACK_IMPORTED_MODULE_6__["UsersPage"]
    }
];
var UsersPageModule = /** @class */ (function () {
    function UsersPageModule() {
    }
    UsersPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_users_page__WEBPACK_IMPORTED_MODULE_6__["UsersPage"]]
        })
    ], UsersPageModule);
    return UsersPageModule;
}());



/***/ }),

/***/ "./src/app/users/users.page.html":
/*!***************************************!*\
  !*** ./src/app/users/users.page.html ***!
  \***************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\n  <ion-toolbar>\n    <ion-title><span class=\"blue\">User manager</span></ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content padding >\n  <div class=\"row\">\n    <div class=\"col s12 m4\">\n      <form (ngSubmit)=\"onSubmit(userForm)\" #userForm=\"ngForm\">\n        <ion-grid>\n          <ion-row justify-content-center>\n            <ion-col align-self-center size-md=\"6\" size-lg=\"5\" size-xs=\"12\">                             \n              <h4>User form </h4>              \n              <div padding>\n                <input type=\"hidden\" name=\"id\" #id=\"ngModel\" [(ngModel)]=\"userService.selectedUser.id\">\n                <ion-item>\n                  <ion-input type=\"text\" #username ngModel name=\"username\" [(ngModel)]=\"userService.selectedUser.username\"\n                    placeholder=\"Имя пользователя\" required></ion-input>\n                </ion-item>\n                <ion-item>\n                  <ion-input type=\"password\" #password ngModel name=\"password\" [(ngModel)]=\"userService.selectedUser.password\"\n                    placeholder=\"Пароль\" required></ion-input>\n                </ion-item>\n                <ion-item>\n                  <ion-input type=\"email\" #email ngModel name=\"email\" [(ngModel)]=\"userService.selectedUser.email\"\n                    placeholder=\"Email\" required></ion-input>\n                </ion-item>\n                <ion-item>\n                  <ion-input type=\"text\" #firstName ngModel name=\"firstName\" [(ngModel)]=\"userService.selectedUser.firstName\"\n                    placeholder=\"Имя\" required></ion-input>\n                </ion-item>\n                <ion-item>\n                  <ion-input type=\"text\" #lastName ngModel name=\"lastName\" [(ngModel)]=\"userService.selectedUser.lastName\"\n                    placeholder=\"Фамилия\" required></ion-input>\n                </ion-item>              \n\n                <ion-item>\n                  <ion-label position=\"floating\">Выберите роль</ion-label>\n                  <ion-select #roles ngModel name=\"roles\" [(ngModel)]=\"userService.selectedUser.roles\"\n                    multiple=\"true\" [compareWith]=\"compareFn\">\n                    <ion-select-option *ngFor=\"let role of userService.rolesList\" [value]=\"role\">\n                      {{role.name}}\n                    </ion-select-option>\n                  </ion-select>\n                </ion-item>                \n              </div>\n              <div padding>\n                <ion-button color=\"light\" size=\"default\" type=\"submit\" expand=\"block\">Create</ion-button>\n                <ion-button color=\"dark\" size=\"default\" type=\"button\" expand=\"block\" (click)=\"resetForm(userForm)\">\n                  Reset\n                </ion-button>\n              </div>\n            </ion-col>\n          </ion-row>\n        </ion-grid>\n      </form>\n    </div>\n  </div>\n  <ion-row justify-content-center>\n    <ion-col align-self-center size-md=\"4\" size-lg=\"4\" size-xs=\"12\">\n      <div *ngFor=\"let user of userService.usersList\">\n        <ion-card>\n          <ion-card-header>\n            <ion-card-title>{{ user.username }}</ion-card-title>\n            <ion-card-subtitle>\n              {{ user.firstName }} - {{ user.lastName }}\n            </ion-card-subtitle>\n          </ion-card-header>\n\n          <ion-card-content> \n            <div *ngFor=\"let role of user.roles\">\n              <ion-chip [routerLink]=\"'/tag-projects/' + role.Id\" color=\"tertiary\">\n                <ion-label  color=\"tertiary\">{{ role.name }}</ion-label>\n              </ion-chip>\n            </div>\n          </ion-card-content>\n          <ion-item>\n            <ion-button color=\"medium\" (click)=\"onDelete(user.id)\">\n              <ion-ripple-effect></ion-ripple-effect>\n              <ion-icon name=\"trash\" slot=\"start\"></ion-icon>\n              Remove\n            </ion-button>\n            <ion-button color=\"light\" (click)=\"showForEdit(user)\">\n              <ion-ripple-effect></ion-ripple-effect>\n              <ion-icon name=\"create\" slot=\"start\"></ion-icon>\n              Edit\n            </ion-button>\n          </ion-item>\n        </ion-card>\n      </div>\n    </ion-col>\n  </ion-row>\n</ion-content>"

/***/ }),

/***/ "./src/app/users/users.page.scss":
/*!***************************************!*\
  !*** ./src/app/users/users.page.scss ***!
  \***************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3VzZXJzL3VzZXJzLnBhZ2Uuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/users/users.page.ts":
/*!*************************************!*\
  !*** ./src/app/users/users.page.ts ***!
  \*************************************/
/*! exports provided: UsersPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UsersPage", function() { return UsersPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_user_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../shared/user.service */ "./src/app/shared/user.service.ts");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");





var UsersPage = /** @class */ (function () {
    function UsersPage(userService, toastController) {
        this.userService = userService;
        this.toastController = toastController;
    }
    UsersPage.prototype.ngOnInit = function () {
        this.userService.getAllUsers();
        this.userService.getRoles();
        this.resetForm();
    };
    UsersPage.prototype.presentToast = function (text, theme) {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
            var toast;
            return tslib__WEBPACK_IMPORTED_MODULE_0__["__generator"](this, function (_a) {
                switch (_a.label) {
                    case 0: return [4 /*yield*/, this.toastController.create({
                            message: text,
                            showCloseButton: true,
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
    UsersPage.prototype.isMatch = function (array) {
        return this.userService.roleMatch(array);
    };
    UsersPage.prototype.showForEdit = function (us) {
        console.log(us);
        this.userService.selectedUser = Object.assign({}, us);
        this.ScrollToTop();
    };
    UsersPage.prototype.ScrollToTop = function () {
        this.content.scrollToTop(800);
    };
    UsersPage.prototype.onDelete = function (id) {
        var _this = this;
        if (confirm('Are you sure to delete this record ?') == true) {
            this.userService.deleteUser(id)
                .subscribe(function (x) {
                _this.userService.getAllUsers();
                _this.presentToast('User deleted!', 'danger');
            });
        }
    };
    UsersPage.prototype.compareFn = function (e1, e2) {
        return e1 && e2 ? e1.id === e2.id : e1 === e2;
    };
    UsersPage.prototype.resetForm = function (form) {
        if (form != null) {
            form.reset();
        }
        this.userService.selectedUser = {
            id: null,
            username: '',
            password: '',
            email: '',
            firstName: '',
            lastName: '',
            roles: []
        };
    };
    UsersPage.prototype.onSubmit = function (form) {
        var _this = this;
        if (form.value.id == null) {
            this.userService.postUser(form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.userService.getAllUsers();
                // this.toast.show(`New company add!`, '5000', 'center').subscribe(
                //   toast => {
                //     console.log(toast);
                //   }
                // );
                _this.presentToast('user created!', 'success');
            });
        }
        else {
            this.userService.putUser(form.value.id, form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.userService.getAllUsers();
                // this.toast.show(`Companies updated`, '5000', 'center').subscribe(
                //   toast => {
                //     this.presentToast('Project updated!', 'warning');
                //   }
                // );
                _this.presentToast('project updated!', 'success');
            });
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])(_ionic_angular__WEBPACK_IMPORTED_MODULE_3__["IonContent"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _ionic_angular__WEBPACK_IMPORTED_MODULE_3__["IonContent"])
    ], UsersPage.prototype, "content", void 0);
    UsersPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-users',
            template: __webpack_require__(/*! ./users.page.html */ "./src/app/users/users.page.html"),
            styles: [__webpack_require__(/*! ./users.page.scss */ "./src/app/users/users.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_user_service__WEBPACK_IMPORTED_MODULE_2__["UserService"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_3__["ToastController"]])
    ], UsersPage);
    return UsersPage;
}());



/***/ })

}]);
//# sourceMappingURL=users-users-module.js.map