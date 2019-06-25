(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["projectform-projectform-module"],{

/***/ "./src/app/projectform/projectform.module.ts":
/*!***************************************************!*\
  !*** ./src/app/projectform/projectform.module.ts ***!
  \***************************************************/
/*! exports provided: ProjectformPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectformPageModule", function() { return ProjectformPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _projectform_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./projectform.page */ "./src/app/projectform/projectform.page.ts");







var routes = [
    {
        path: '',
        component: _projectform_page__WEBPACK_IMPORTED_MODULE_6__["ProjectformPage"]
    }
];
var ProjectformPageModule = /** @class */ (function () {
    function ProjectformPageModule() {
    }
    ProjectformPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_projectform_page__WEBPACK_IMPORTED_MODULE_6__["ProjectformPage"]]
        })
    ], ProjectformPageModule);
    return ProjectformPageModule;
}());



/***/ }),

/***/ "./src/app/projectform/projectform.page.html":
/*!***************************************************!*\
  !*** ./src/app/projectform/projectform.page.html ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n<ion-content padding>\r\n  <div class=\"row\">\r\n    <div class=\"col s12 m4\">\r\n      <form (ngSubmit)=\"onSubmit(projectForm)\" #projectForm=\"ngForm\">\r\n        <ion-grid>\r\n          <ion-row justify-content-center>\r\n            <ion-col align-self-center size-md=\"6\" size-lg=\"5\" size-xs=\"12\">\r\n              <div text-center>                  \r\n                <h4>Форма проекта </h4>\r\n              </div>\r\n              <div padding>\r\n                <input type=\"hidden\" name=\"ID\" #ID=\"ngModel\" [(ngModel)]=\"projectService.selectedProject.id\">\r\n                <ion-item>\r\n                  <ion-input type=\"text\" #name ngModel name=\"name\" [(ngModel)]=\"projectService.selectedProject.name\"\r\n                    placeholder=\"Название\" required></ion-input>\r\n                </ion-item>\r\n                <ion-item>\r\n                  <ion-datetime #startDate ngModel name=\"startDate\" placeholder=\"Начало\"\r\n                    [(ngModel)]=\"projectService.selectedProject.startDate\" display-format=\"DD/MM/YYYY\"\r\n                    picker-format=\"DD MM YYYY\"></ion-datetime>\r\n                </ion-item>\r\n\r\n                <ion-item>\r\n                  <ion-datetime #endDate ngModel name=\"endDate\" placeholder=\"Конец\"\r\n                    [(ngModel)]=\"projectService.selectedProject.endDate\" display-format=\"DD/MM/YYYY\"\r\n                    picker-format=\"DD MM YYYY\"></ion-datetime>\r\n                </ion-item>\r\n\r\n                <ion-item>\r\n                  <ion-textarea #description ngModel name=\"description\"\r\n                    [(ngModel)]=\"projectService.selectedProject.description\" placeholder=\"Описание\" required>\r\n                  </ion-textarea>\r\n                </ion-item>\r\n                <ion-item>\r\n                  <ion-label position=\"floating\">Выберите спринты</ion-label>\r\n                  <ion-select #sprints ngModel name=\"sprints\" [(ngModel)]=\"projectService.selectedProject.sprints\"\r\n                    multiple=\"true\" [compareWith]=\"compareFn\">\r\n                    <ion-select-option *ngFor=\"let sprint of sprintService.sprintsList\" [value]=\"sprint\">\r\n                      {{sprint.name}}\r\n                    </ion-select-option>\r\n                  </ion-select>\r\n                </ion-item>\r\n                <ion-item>\r\n                  <ion-label position=\"floating\">Выберите теги</ion-label>\r\n                  <ion-select #tags ngModel name=\"tags\" [(ngModel)]=\"projectService.selectedProject.tags\"\r\n                    multiple=\"true\" [compareWith]=\"compareFn\">\r\n                    <ion-select-option *ngFor=\"let tag of tagService.tagsList\" [value]=\"tag\">\r\n                      {{tag.name}}\r\n                    </ion-select-option>\r\n                  </ion-select>\r\n                </ion-item>\r\n              </div>\r\n              <div padding>\r\n                <ion-button color=\"light\" size=\"default\" type=\"submit\" expand=\"block\">Сохранить</ion-button>\r\n                <ion-button color=\"dark\" size=\"default\" type=\"button\" expand=\"block\" (click)=\"resetForm(projectForm)\">\r\n                  Сбросить\r\n                </ion-button>\r\n              </div>\r\n            </ion-col>\r\n          </ion-row>\r\n        </ion-grid>\r\n      </form>\r\n    </div>\r\n  </div>\r\n</ion-content>\r\n"

/***/ }),

/***/ "./src/app/projectform/projectform.page.scss":
/*!***************************************************!*\
  !*** ./src/app/projectform/projectform.page.scss ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Byb2plY3Rmb3JtL3Byb2plY3Rmb3JtLnBhZ2Uuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/projectform/projectform.page.ts":
/*!*************************************************!*\
  !*** ./src/app/projectform/projectform.page.ts ***!
  \*************************************************/
/*! exports provided: ProjectformPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectformPage", function() { return ProjectformPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_project_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../shared/project.service */ "./src/app/shared/project.service.ts");
/* harmony import */ var _shared_sprint_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../shared/sprint.service */ "./src/app/shared/sprint.service.ts");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _shared_tag_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../shared/tag.service */ "./src/app/shared/tag.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");







var ProjectformPage = /** @class */ (function () {
    function ProjectformPage(projectService, sprintService, tagService, toastController, router) {
        this.projectService = projectService;
        this.sprintService = sprintService;
        this.tagService = tagService;
        this.toastController = toastController;
        this.router = router;
    }
    ProjectformPage.prototype.ngOnInit = function () {
    };
    ProjectformPage.prototype.presentToast = function (text, theme) {
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
    ProjectformPage.prototype.compareFn = function (e1, e2) {
        return e1 && e2 ? e1.id === e2.id : e1 === e2;
    };
    ProjectformPage.prototype.onSubmit = function (form) {
        var _this = this;
        if (form.value.ID == null) {
            this.projectService.postProject(form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.projectService.getAllProjects();
                _this.projectService.updateSelectedProject();
                _this.router.navigate(["/project/" + _this.projectService.projectId]);
                _this.presentToast('project created!', 'success');
            });
        }
        else {
            this.projectService.putProject(form.value.ID, form.value).subscribe(function (data) {
                _this.projectService.updateSelectedProject();
                _this.resetForm(form);
                _this.projectService.getAllProjects();
                _this.router.navigateByUrl("/project/" + _this.projectService.projectId);
                _this.presentToast('project updated!', 'success');
            });
        }
    };
    ProjectformPage.prototype.resetForm = function (form) {
        if (form != null) {
            form.reset();
        }
        this.projectService.selectedProject = {
            id: null,
            name: '',
            description: '',
            startDate: '',
            endDate: '',
            sprints: [],
            tags: []
        };
    };
    ProjectformPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-projectform',
            template: __webpack_require__(/*! ./projectform.page.html */ "./src/app/projectform/projectform.page.html"),
            styles: [__webpack_require__(/*! ./projectform.page.scss */ "./src/app/projectform/projectform.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_project_service__WEBPACK_IMPORTED_MODULE_2__["ProjectService"],
            _shared_sprint_service__WEBPACK_IMPORTED_MODULE_3__["SprintService"],
            _shared_tag_service__WEBPACK_IMPORTED_MODULE_5__["TagService"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["ToastController"],
            _angular_router__WEBPACK_IMPORTED_MODULE_6__["Router"]])
    ], ProjectformPage);
    return ProjectformPage;
}());



/***/ })

}]);
//# sourceMappingURL=projectform-projectform-module.js.map