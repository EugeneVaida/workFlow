(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["sprintform-sprintform-module"],{

/***/ "./src/app/sprintform/sprintform.module.ts":
/*!*************************************************!*\
  !*** ./src/app/sprintform/sprintform.module.ts ***!
  \*************************************************/
/*! exports provided: SprintformPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SprintformPageModule", function() { return SprintformPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _sprintform_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./sprintform.page */ "./src/app/sprintform/sprintform.page.ts");







var routes = [
    {
        path: '',
        component: _sprintform_page__WEBPACK_IMPORTED_MODULE_6__["SprintformPage"]
    }
];
var SprintformPageModule = /** @class */ (function () {
    function SprintformPageModule() {
    }
    SprintformPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_sprintform_page__WEBPACK_IMPORTED_MODULE_6__["SprintformPage"]]
        })
    ], SprintformPageModule);
    return SprintformPageModule;
}());



/***/ }),

/***/ "./src/app/sprintform/sprintform.page.html":
/*!*************************************************!*\
  !*** ./src/app/sprintform/sprintform.page.html ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\n  <ion-toolbar>\n    <ion-title class=\"blue\">Форма спринта</ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content padding>\n    <div class=\"row\">\n        <div class=\"col s12 m4\">\n          <form (ngSubmit)=\"onSubmit(sprintForm)\" #sprintForm=\"ngForm\">\n            <ion-grid>\n              <ion-row justify-content-center>\n                <ion-col align-self-center size-md=\"6\" size-lg=\"5\" size-xs=\"12\">\n                  <div text-center>\n                    <h4>Форма спринта</h4>\n                  </div>\n                  <div padding>\n                    <input type=\"hidden\" name=\"ID\" #ID=\"ngModel\" [(ngModel)]=\"sprintService.selectedSprint.id\">                    \n                    <ion-item>\n                      <ion-input type=\"text\" #name ngModel name=\"name\" [(ngModel)]=\"sprintService.selectedSprint.name\"\n                        placeholder=\"Название\" required></ion-input>\n                    </ion-item>\n                    <ion-item>\n                      <ion-datetime #startDate ngModel name=\"startDate\" placeholder=\"Начало\"\n                        [(ngModel)]=\"sprintService.selectedSprint.startDate\" display-format=\"DD/MM/YYYY\"\n                        picker-format=\"DD MM YYYY\"></ion-datetime>\n                    </ion-item>\n    \n                    <ion-item>\n                      <ion-datetime #endDate ngModel name=\"endDate\" placeholder=\"Конец\"\n                        [(ngModel)]=\"sprintService.selectedSprint.endDate\" display-format=\"DD/MM/YYYY\"\n                        picker-format=\"DD MM YYYY\"></ion-datetime>\n                    </ion-item>\n    \n                    <ion-item>\n                      <ion-input type=\"text\" #description ngModel name=\"description\"\n                        [(ngModel)]=\"sprintService.selectedSprint.description\" placeholder=\"Описание\" required></ion-input>\n                    </ion-item>\n                    <ion-item>\n                      <ion-select #priority ngModel name=\"priority\" [(ngModel)]=\"sprintService.selectedSprint.priority\"\n                        placeholder=\"\">\n                        <ion-select-option [value]=1>Высокий</ion-select-option>\n                        <ion-select-option [value]=2>Низкий</ion-select-option>\n                      </ion-select>\n                    </ion-item>\n                    <ion-item>                      \n                      <ion-select #projects ngModel name=\"projects\" [(ngModel)]=\"sprintService.selectedSprint.projects\"\n                        multiple=\"true\" [compareWith]=\"compareFn\">\n                        <ion-select-option *ngFor=\"let project of projectService.projectsList\" [value]=\"project\">\n                          {{project.name}}\n                        </ion-select-option>\n                      </ion-select>\n                    </ion-item>\n                  </div>\n                  <div padding>\n                    <ion-button color=\"light\" size=\"default\" type=\"submit\" expand=\"block\">Сохранить</ion-button>\n                    <ion-button color=\"dark\" size=\"default\" type=\"button\" expand=\"block\" (click)=\"resetForm(sprintForm)\">\n                      Сбросить\n                    </ion-button>\n                  </div>\n                </ion-col>\n              </ion-row>\n            </ion-grid>\n          </form>\n        </div>\n      </div>\n</ion-content>\n"

/***/ }),

/***/ "./src/app/sprintform/sprintform.page.scss":
/*!*************************************************!*\
  !*** ./src/app/sprintform/sprintform.page.scss ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NwcmludGZvcm0vc3ByaW50Zm9ybS5wYWdlLnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/sprintform/sprintform.page.ts":
/*!***********************************************!*\
  !*** ./src/app/sprintform/sprintform.page.ts ***!
  \***********************************************/
/*! exports provided: SprintformPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SprintformPage", function() { return SprintformPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_project_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../shared/project.service */ "./src/app/shared/project.service.ts");
/* harmony import */ var _shared_sprint_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../shared/sprint.service */ "./src/app/shared/sprint.service.ts");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _shared_tag_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../shared/tag.service */ "./src/app/shared/tag.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");







var SprintformPage = /** @class */ (function () {
    function SprintformPage(projectService, sprintService, tagService, toastController, router) {
        this.projectService = projectService;
        this.sprintService = sprintService;
        this.tagService = tagService;
        this.toastController = toastController;
        this.router = router;
    }
    SprintformPage.prototype.ngOnInit = function () {
    };
    SprintformPage.prototype.presentToast = function (text, theme) {
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
    SprintformPage.prototype.resetForm = function (form) {
        if (form != null) {
            form.reset();
        }
        this.sprintService.selectedSprint = {
            id: null,
            name: '',
            description: '',
            startDate: '',
            endDate: '',
            percent: 0,
            priority: 0,
            isDone: false,
            projects: []
        };
    };
    SprintformPage.prototype.onSubmit = function (form) {
        var _this = this;
        if (form.value.ID == null) {
            this.sprintService.postSprint(form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.sprintService.getAllSprints();
                _this.projectService.getAllProjects();
                _this.presentToast('Sprint created!', 'success');
            });
        }
        else {
            this.sprintService.putSprint(form.value.ID, form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.sprintService.getAllSprints();
                _this.projectService.getAllProjects();
                _this.presentToast('Sprint updated!', 'success');
            });
        }
    };
    SprintformPage.prototype.compareFn = function (e1, e2) {
        return e1 && e2 ? e1.id === e2.id : e1 === e2;
    };
    SprintformPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-sprintform',
            template: __webpack_require__(/*! ./sprintform.page.html */ "./src/app/sprintform/sprintform.page.html"),
            styles: [__webpack_require__(/*! ./sprintform.page.scss */ "./src/app/sprintform/sprintform.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_project_service__WEBPACK_IMPORTED_MODULE_2__["ProjectService"],
            _shared_sprint_service__WEBPACK_IMPORTED_MODULE_3__["SprintService"],
            _shared_tag_service__WEBPACK_IMPORTED_MODULE_5__["TagService"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["ToastController"],
            _angular_router__WEBPACK_IMPORTED_MODULE_6__["Router"]])
    ], SprintformPage);
    return SprintformPage;
}());



/***/ })

}]);
//# sourceMappingURL=sprintform-sprintform-module.js.map