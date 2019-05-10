(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["companies-companies-module"],{

/***/ "./src/app/companies/companies.module.ts":
/*!***********************************************!*\
  !*** ./src/app/companies/companies.module.ts ***!
  \***********************************************/
/*! exports provided: CompaniesPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CompaniesPageModule", function() { return CompaniesPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _companies_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./companies.page */ "./src/app/companies/companies.page.ts");







var routes = [
    {
        path: '',
        component: _companies_page__WEBPACK_IMPORTED_MODULE_6__["CompaniesPage"]
    }
];
var CompaniesPageModule = /** @class */ (function () {
    function CompaniesPageModule() {
    }
    CompaniesPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_companies_page__WEBPACK_IMPORTED_MODULE_6__["CompaniesPage"]]
        })
    ], CompaniesPageModule);
    return CompaniesPageModule;
}());



/***/ }),

/***/ "./src/app/companies/companies.page.html":
/*!***********************************************!*\
  !*** ./src/app/companies/companies.page.html ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\n  <ion-toolbar>\n    <ion-title><span class=\"blue\">Companies</span></ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content padding>\n\n  <div class=\"row\">\n    <div class=\"col s12 m4\">\n      <form (ngSubmit)=\"onSubmit(companyForm)\" #companyForm=\"ngForm\">\n        <ion-grid>\n          <ion-row justify-content-center>\n            <ion-col align-self-center size-md=\"6\" size-lg=\"5\" size-xs=\"12\">\n              <div text-center>\n                <h4>Company form</h4>\n              </div>\n              <div padding>\n                <input type=\"hidden\" name=\"ID\" #ID=\"ngModel\" [(ngModel)]=\"companyService.selectedCompany.id\">\n                <ion-item>\n                  <ion-input type=\"text\" #name ngModel name=\"name\" [(ngModel)]=\"companyService.selectedCompany.name\"\n                    placeholder=\"Название компании\" required></ion-input>\n                </ion-item>\n\n                <ion-item>\n                  <ion-input type=\"text\" #adress ngModel name=\"adress\"\n                    [(ngModel)]=\"companyService.selectedCompany.adress\" placeholder=\"Адрес\" required></ion-input>\n                </ion-item>\n\n                <ion-item>\n                  <ion-input type=\"text\" #telephone ngModel name=\"telephone\"\n                    [(ngModel)]=\"companyService.selectedCompany.telephone\" placeholder=\"Телефон\" required></ion-input>\n                </ion-item>\n              </div>\n              <div padding>\n                <ion-button size=\"small\" type=\"submit\" expand=\"block\">Create</ion-button>\n                <ion-button size=\"small\" type=\"button\" expand=\"block\" (click)=\"resetForm(companyForm)\">Reset\n                </ion-button>\n              </div>\n            </ion-col>\n          </ion-row>\n        </ion-grid>\n      </form>\n    </div>\n  </div>\n\n\n  <ion-row justify-content-center>\n    <ion-col align-self-center size-md=\"4\" size-lg=\"4\" size-xs=\"12\">\n      <div *ngFor=\"let company of companyService.companiesList\">\n        <ion-card>\n          <ion-card-header>\n            <ion-card-title>{{ company.name }}</ion-card-title>\n            <ion-card-subtitle>{{ company.adress }}</ion-card-subtitle>\n          </ion-card-header>\n\n          <ion-card-content>\n            {{ company.telephone }}\n          </ion-card-content>\n          <ion-item (click)=\"onDelete(company.id)\" class=\"activated\">\n            <ion-icon name=\"trash\" slot=\"start\"></ion-icon>\n            <ion-label>Remove</ion-label>\n          </ion-item>\n\n          <ion-item (click)=\"showForEdit(company)\">\n            <ion-icon name=\"create\" slot=\"start\"></ion-icon>\n            <ion-label>Edit</ion-label>\n          </ion-item>\n        </ion-card>\n      </div>\n    </ion-col>\n  </ion-row>\n\n\n</ion-content>"

/***/ }),

/***/ "./src/app/companies/companies.page.scss":
/*!***********************************************!*\
  !*** ./src/app/companies/companies.page.scss ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2NvbXBhbmllcy9jb21wYW5pZXMucGFnZS5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/companies/companies.page.ts":
/*!*********************************************!*\
  !*** ./src/app/companies/companies.page.ts ***!
  \*********************************************/
/*! exports provided: CompaniesPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CompaniesPage", function() { return CompaniesPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_company_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../shared/company.service */ "./src/app/shared/company.service.ts");
/* harmony import */ var _shared_user_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../shared/user.service */ "./src/app/shared/user.service.ts");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");





var CompaniesPage = /** @class */ (function () {
    function CompaniesPage(companyService, toastController, userService) {
        this.companyService = companyService;
        this.toastController = toastController;
        this.userService = userService;
    }
    CompaniesPage.prototype.presentToast = function (text, theme) {
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
    CompaniesPage.prototype.ngOnInit = function () {
        this.resetForm();
        this.companyService.getAllCompanies();
    };
    CompaniesPage.prototype.showForEdit = function (cpm) {
        this.companyService.selectedCompany = Object.assign({}, cpm);
    };
    CompaniesPage.prototype.onDelete = function (id) {
        var _this = this;
        if (confirm('Are you sure to delete this record ?') == true) {
            this.companyService.deleteCompany(id)
                .subscribe(function (x) {
                _this.companyService.getAllCompanies();
                _this.presentToast('Company deleted!', 'danger');
            });
        }
    };
    CompaniesPage.prototype.resetForm = function (form) {
        if (form != null) {
            form.reset();
        }
        this.companyService.selectedCompany = {
            id: null,
            name: '',
            adress: '',
            telephone: ''
        };
    };
    CompaniesPage.prototype.onSubmit = function (form) {
        var _this = this;
        if (form.value.ID == null) {
            this.companyService.postCompany(form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.companyService.getAllCompanies();
                _this.presentToast('Company created!', 'warning');
            });
        }
        else {
            this.companyService.putCompany(form.value.ID, form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.companyService.getAllCompanies();
                _this.presentToast('Company updated!', 'warning');
            });
        }
    };
    CompaniesPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-companies',
            template: __webpack_require__(/*! ./companies.page.html */ "./src/app/companies/companies.page.html"),
            providers: [_shared_company_service__WEBPACK_IMPORTED_MODULE_2__["CompanyService"]],
            styles: [__webpack_require__(/*! ./companies.page.scss */ "./src/app/companies/companies.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_company_service__WEBPACK_IMPORTED_MODULE_2__["CompanyService"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["ToastController"],
            _shared_user_service__WEBPACK_IMPORTED_MODULE_3__["UserService"]])
    ], CompaniesPage);
    return CompaniesPage;
}());



/***/ })

}]);
//# sourceMappingURL=companies-companies-module.js.map