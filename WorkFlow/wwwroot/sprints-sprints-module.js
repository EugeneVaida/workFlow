(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["sprints-sprints-module"],{

/***/ "./src/app/sprints/sprints.module.ts":
/*!*******************************************!*\
  !*** ./src/app/sprints/sprints.module.ts ***!
  \*******************************************/
/*! exports provided: SprintsPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SprintsPageModule", function() { return SprintsPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _sprints_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./sprints.page */ "./src/app/sprints/sprints.page.ts");







var routes = [
    {
        path: '',
        component: _sprints_page__WEBPACK_IMPORTED_MODULE_6__["SprintsPage"]
    }
];
var SprintsPageModule = /** @class */ (function () {
    function SprintsPageModule() {
    }
    SprintsPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_sprints_page__WEBPACK_IMPORTED_MODULE_6__["SprintsPage"]]
        })
    ], SprintsPageModule);
    return SprintsPageModule;
}());



/***/ }),

/***/ "./src/app/sprints/sprints.page.html":
/*!*******************************************!*\
  !*** ./src/app/sprints/sprints.page.html ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\n  <ion-toolbar>\n    <ion-title><span class=\"blue\">Sprints</span></ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content padding>\n\n  <div class=\"row\">\n    <div class=\"col s12 m4\">\n      <form (ngSubmit)=\"onSubmit(sprintForm)\" #sprintForm=\"ngForm\">\n        <ion-grid>\n          <ion-row justify-content-center>\n            <ion-col align-self-center size-md=\"6\" size-lg=\"5\" size-xs=\"12\">\n              <div text-center>\n                <h4>Sprint form</h4>\n              </div>\n              <div padding>\n                <input type=\"hidden\" name=\"ID\" #ID=\"ngModel\" [(ngModel)]=\"sprintService.selectedSprint.id\">\n                <input type=\"hidden\" name=\"projects\" ngModel [(ngModel)]=\"sprintService.selectedSprint.projects\">\n                <ion-item>\n                  <ion-input type=\"text\" #name ngModel name=\"name\" [(ngModel)]=\"sprintService.selectedSprint.name\"\n                    placeholder=\"Название\" required></ion-input>\n                </ion-item>\n                <ion-item>\n                  <ion-datetime #startDate ngModel name=\"startDate\" placeholder=\"Начало\"\n                    [(ngModel)]=\"sprintService.selectedSprint.startDate\" display-format=\"DD/MM/YYYY\"\n                    picker-format=\"DD MM YYYY\"></ion-datetime>\n                </ion-item>\n\n                <ion-item>\n                  <ion-datetime #endDate ngModel name=\"endDate\" placeholder=\"Конец\"\n                    [(ngModel)]=\"sprintService.selectedSprint.endDate\" display-format=\"DD/MM/YYYY\"\n                    picker-format=\"DD MM YYYY\"></ion-datetime>\n                </ion-item>\n\n                <ion-item>\n                  <ion-input type=\"text\" #description ngModel name=\"description\"\n                    [(ngModel)]=\"sprintService.selectedSprint.description\" placeholder=\"Описание\" required></ion-input>\n                </ion-item>\n                <ion-item>\n                  <ion-select #priority ngModel name=\"priority\" [(ngModel)]=\"sprintService.selectedSprint.priority\"\n                    placeholder=\"\">\n                    <ion-select-option [value]=1>Hight</ion-select-option>\n                    <ion-select-option [value]=2>Low</ion-select-option>\n                  </ion-select>\n                </ion-item>\n                <ion-item>\n                  <ion-select #projects ngModel name=\"projects\" [(ngModel)]=\"sprintService.selectedSprint.projects\"\n                    multiple=\"true\" [compareWith]=\"compareFn\">\n                    <ion-select-option *ngFor=\"let project of projectService.projectsList\" [value]=\"project\">\n                      {{project.name}}\n                    </ion-select-option>\n                    <!-- <ion-select-option *ngFor=\"let project of unselectedProjects\" [value]=\"project\">\n                      {{project.name}}\n                    </ion-select-option> -->\n                  </ion-select>\n                </ion-item>\n              </div>\n              <div padding>\n                <ion-button color=\"light\" size=\"default\" type=\"submit\" expand=\"block\">Create</ion-button>\n                <ion-button color=\"dark\" size=\"default\" type=\"button\" expand=\"block\" (click)=\"resetForm(sprintForm)\">\n                  Reset\n                </ion-button>\n              </div>\n            </ion-col>\n          </ion-row>\n        </ion-grid>\n      </form>\n    </div>\n  </div>\n\n\n  <ion-row justify-content-center>\n    <ion-col align-self-center size-md=\"4\" size-lg=\"4\" size-xs=\"12\">\n      <div *ngFor=\"let sprint of sprintService.sprintsList\">\n        <ion-card>\n          <ion-card-header>\n            <ion-card-title>\n              {{ sprint.name }}\n              <ion-icon *ngIf=\"sprint.isDone\" color=\"success\" name=\"checkmark-circle\"></ion-icon>\n            </ion-card-title>\n            <ion-card-subtitle>\n              {{ sprint.startDate | date: \"dd/MM/yyyy\"}} - {{ sprint.endDate | date: \"dd/MM/yyyy\"}}\n            </ion-card-subtitle>\n          </ion-card-header>\n          <ion-progress-bar color=\"tertiary\" value=\"0.{{sprint.percent}}\"></ion-progress-bar>\n          <ion-card-content>\n            {{ sprint.description }}\n            <div *ngFor=\"let project of sprint.projects\">\n              <ion-chip>\n                <ion-label>{{ project.name }}</ion-label>\n              </ion-chip>\n            </div>\n          </ion-card-content>\n          <ion-item (click)=\"onDelete(sprint.id)\" class=\"activated\">\n            <ion-icon name=\"trash\" slot=\"start\"></ion-icon>\n            <ion-label>Remove</ion-label>\n          </ion-item>\n\n          <ion-item (click)=\"showForEdit(sprint)\">\n            <ion-icon name=\"create\" slot=\"start\"></ion-icon>\n            <ion-label>Edit</ion-label>\n          </ion-item>\n        </ion-card>\n      </div>\n    </ion-col>\n  </ion-row>\n\n\n</ion-content>"

/***/ }),

/***/ "./src/app/sprints/sprints.page.scss":
/*!*******************************************!*\
  !*** ./src/app/sprints/sprints.page.scss ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NwcmludHMvc3ByaW50cy5wYWdlLnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/sprints/sprints.page.ts":
/*!*****************************************!*\
  !*** ./src/app/sprints/sprints.page.ts ***!
  \*****************************************/
/*! exports provided: SprintsPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SprintsPage", function() { return SprintsPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_sprint_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../shared/sprint.service */ "./src/app/shared/sprint.service.ts");
/* harmony import */ var _shared_project_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../shared/project.service */ "./src/app/shared/project.service.ts");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");





var SprintsPage = /** @class */ (function () {
    function SprintsPage(sprintService, projectService, toastController) {
        this.sprintService = sprintService;
        this.projectService = projectService;
        this.toastController = toastController;
    }
    SprintsPage.prototype.presentToast = function (text, theme) {
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
    SprintsPage.prototype.ngOnInit = function () {
        this.sprintService.getAllSprints();
        this.projectService.getAllProjects();
        this.resetForm();
    };
    SprintsPage.prototype.showForEdit = function (spr) {
        this.sprintService.selectedSprint = Object.assign({}, spr);
        this.ScrollToTop();
    };
    SprintsPage.prototype.ScrollToTop = function () {
        this.content.scrollToTop(800);
    };
    SprintsPage.prototype.onDelete = function (id) {
        var _this = this;
        if (confirm('Are you sure to delete this record ?') == true) {
            this.sprintService.deleteSprint(id)
                .subscribe(function (x) {
                _this.sprintService.getAllSprints();
                _this.presentToast('Sprint deleted!', 'danger');
            });
        }
    };
    SprintsPage.prototype.resetForm = function (form) {
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
    SprintsPage.prototype.onSubmit = function (form) {
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
    SprintsPage.prototype.compareFn = function (e1, e2) {
        return e1 && e2 ? e1.id === e2.id : e1 === e2;
    };
    SprintsPage.prototype.multiChange = function () {
        console.table(this.sprintService.selectedSprint.projects);
    };
    ;
    SprintsPage.prototype.containsObject = function (obj, list) {
        //console.log(`enter values ${obj} - ${list}`);
        var project = Object.assign({}, obj);
        var list1 = Object.assign({}, list);
        var i;
        for (i = 0; i < list1.length; i++) {
            if (list[i] === project) {
                console.log(true);
                return "true";
            }
        }
        return "false";
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])(_ionic_angular__WEBPACK_IMPORTED_MODULE_4__["IonContent"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["IonContent"])
    ], SprintsPage.prototype, "content", void 0);
    SprintsPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-sprints',
            template: __webpack_require__(/*! ./sprints.page.html */ "./src/app/sprints/sprints.page.html"),
            providers: [_shared_sprint_service__WEBPACK_IMPORTED_MODULE_2__["SprintService"], _shared_project_service__WEBPACK_IMPORTED_MODULE_3__["ProjectService"]],
            styles: [__webpack_require__(/*! ./sprints.page.scss */ "./src/app/sprints/sprints.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_sprint_service__WEBPACK_IMPORTED_MODULE_2__["SprintService"],
            _shared_project_service__WEBPACK_IMPORTED_MODULE_3__["ProjectService"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["ToastController"]])
    ], SprintsPage);
    return SprintsPage;
}());



/***/ })

}]);
//# sourceMappingURL=sprints-sprints-module.js.map