(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["projects-projects-module"],{

/***/ "./src/app/projects/projects.module.ts":
/*!*********************************************!*\
  !*** ./src/app/projects/projects.module.ts ***!
  \*********************************************/
/*! exports provided: ProjectsPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectsPageModule", function() { return ProjectsPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _projects_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./projects.page */ "./src/app/projects/projects.page.ts");







var routes = [
    {
        path: '',
        component: _projects_page__WEBPACK_IMPORTED_MODULE_6__["ProjectsPage"]
    }
];
var ProjectsPageModule = /** @class */ (function () {
    function ProjectsPageModule() {
    }
    ProjectsPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_projects_page__WEBPACK_IMPORTED_MODULE_6__["ProjectsPage"]]
        })
    ], ProjectsPageModule);
    return ProjectsPageModule;
}());



/***/ }),

/***/ "./src/app/projects/projects.page.html":
/*!*********************************************!*\
  !*** ./src/app/projects/projects.page.html ***!
  \*********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\n  <ion-toolbar>\n    <ion-title>\n      <span class=\"blue\">Projects</span>\n      \n    </ion-title>    \n  </ion-toolbar>\n</ion-header>\n\n<ion-content padding> \n  <ion-spinner *ngIf=\"projectService.isLoad && tagService.isLoad && sprintService.isLoad\"></ion-spinner>\n  <div class=\"row\" *ngIf=\"!projectService.isLoad && !tagService.isLoad && !sprintService.isLoad\">\n    <div class=\"col s12 m4\">\n      <form (ngSubmit)=\"onSubmit(projectForm)\" #projectForm=\"ngForm\">\n        <ion-grid>\n          <ion-row justify-content-center>\n            <ion-col align-self-center size-md=\"6\" size-lg=\"5\" size-xs=\"12\">\n              <div text-center *ngIf=\"isMatch(['Manager'])\">                  \n                <h4>Project form </h4>\n              </div>\n              <div padding>\n                <input type=\"hidden\" name=\"ID\" #ID=\"ngModel\" [(ngModel)]=\"projectService.selectedProject.id\">\n                <ion-item>\n                  <ion-input type=\"text\" #name ngModel name=\"name\" [(ngModel)]=\"projectService.selectedProject.name\"\n                    placeholder=\"Название\" required></ion-input>\n                </ion-item>\n                <ion-item>\n                  <ion-datetime #startDate ngModel name=\"startDate\" placeholder=\"Начало\"\n                    [(ngModel)]=\"projectService.selectedProject.startDate\" display-format=\"DD/MM/YYYY\"\n                    picker-format=\"DD MM YYYY\"></ion-datetime>\n                </ion-item>\n\n                <ion-item>\n                  <ion-datetime #endDate ngModel name=\"endDate\" placeholder=\"Конец\"\n                    [(ngModel)]=\"projectService.selectedProject.endDate\" display-format=\"DD/MM/YYYY\"\n                    picker-format=\"DD MM YYYY\"></ion-datetime>\n                </ion-item>\n\n                <ion-item>\n                  <ion-textarea #description ngModel name=\"description\"\n                    [(ngModel)]=\"projectService.selectedProject.description\" placeholder=\"Описание\" required>\n                  </ion-textarea>\n                </ion-item>\n                <ion-item>\n                  <ion-label position=\"floating\">Выберите спринты</ion-label>\n                  <ion-select #sprints ngModel name=\"sprints\" [(ngModel)]=\"projectService.selectedProject.sprints\"\n                    multiple=\"true\" [compareWith]=\"compareFn\">\n                    <ion-select-option *ngFor=\"let sprint of sprintService.sprintsList\" [value]=\"sprint\">\n                      {{sprint.name}}\n                    </ion-select-option>\n                  </ion-select>\n                </ion-item>\n                <ion-item>\n                  <ion-label position=\"floating\">Выберите теги</ion-label>\n                  <ion-select #tags ngModel name=\"tags\" [(ngModel)]=\"projectService.selectedProject.tags\"\n                    multiple=\"true\" [compareWith]=\"compareFn\">\n                    <ion-select-option *ngFor=\"let tag of tagService.tagsList\" [value]=\"tag\">\n                      {{tag.name}}\n                    </ion-select-option>\n                  </ion-select>\n                </ion-item>\n              </div>\n              <div padding>\n                <ion-button color=\"light\" size=\"default\" type=\"submit\" expand=\"block\">Create</ion-button>\n                <ion-button color=\"dark\" size=\"default\" type=\"button\" expand=\"block\" (click)=\"resetForm(projectForm)\">\n                  Reset\n                </ion-button>\n              </div>\n            </ion-col>\n          </ion-row>\n        </ion-grid>\n      </form>\n    </div>\n  </div>\n  <ion-row justify-content-center>    \n    <ion-col align-self-center size-md=\"4\" size-lg=\"4\" size-xs=\"12\">\n      <div *ngFor=\"let project of projectService.projectsList\">\n        <ion-card>\n          <ion-card-header>\n            <ion-card-title>{{ project.name }}</ion-card-title>\n            <ion-card-subtitle>\n              {{ project.startDate | date: \"dd/MM/yyyy\"}} - {{ project.endDate | date: \"dd/MM/yyyy\"}}\n            </ion-card-subtitle>\n          </ion-card-header>\n\n          <ion-card-content>\n            {{ project.description }}\n            <ion-list *ngFor=\"let sprint of project.sprints\">\n              <ion-item-sliding>\n                <ion-item-options side=\"start\">\n                  <ion-item-option color=\"danger\" (click)=\"deleteSprint(sprint.id, project)\">Delete</ion-item-option>\n                </ion-item-options>\n                <ion-item>\n                  <ion-label>{{ sprint.name }}</ion-label>\n                  <ion-icon *ngIf=\"sprint.isDone\" color=\"tertiary\" name=\"checkmark-circle\"></ion-icon>\n                </ion-item>\n                <ion-item-options side=\"end\">\n                  <ion-item-option color=\"warning\" (click)=\"markSprintAsDone(sprint.id, project.id)\">Done!\n                  </ion-item-option>\n                </ion-item-options>\n              </ion-item-sliding>\n            </ion-list>\n\n            <div *ngFor=\"let tag of project.tags\">\n              <ion-chip [routerLink]=\"'/tag-projects/' + tag.id\" color=\"tertiary\">\n                <ion-label  color=\"tertiary\">{{ tag.name }}</ion-label>\n              </ion-chip>\n            </div>\n          </ion-card-content>\n          <ion-item>\n              \n            <ion-button color=\"medium\" (click)=\"onDelete(project.id)\">\n              <ion-ripple-effect></ion-ripple-effect>\n              <ion-icon name=\"trash\" slot=\"start\"></ion-icon>\n              Remove\n            </ion-button>\n            <ion-button color=\"light\" (click)=\"showForEdit(project)\">\n              <ion-ripple-effect></ion-ripple-effect>\n              <ion-icon name=\"create\" slot=\"start\"></ion-icon>\n              Edit\n            </ion-button>\n            <ion-button color=\"primary\" [routerLink]=\"'/project/' + project.id\">\n                <ion-ripple-effect></ion-ripple-effect>\n                <ion-icon name=\"arrow-forward\" slot=\"start\"></ion-icon>\n                Open\n              </ion-button>\n          </ion-item>\n        </ion-card>\n      </div>\n    </ion-col>\n  </ion-row>\n</ion-content>"

/***/ }),

/***/ "./src/app/projects/projects.page.scss":
/*!*********************************************!*\
  !*** ./src/app/projects/projects.page.scss ***!
  \*********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "ion-spinner {\n  display: block;\n  margin: 0 auto; }\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvcHJvamVjdHMvRDpcXHByb2plY3RzXFxXb3JrRmxvd0NsaWVudFxcd29ya0Zsb3cvc3JjXFxhcHBcXHByb2plY3RzXFxwcm9qZWN0cy5wYWdlLnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSxjQUFjO0VBQ2QsY0FBYyxFQUFBIiwiZmlsZSI6InNyYy9hcHAvcHJvamVjdHMvcHJvamVjdHMucGFnZS5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiaW9uLXNwaW5uZXIge1xyXG4gICAgZGlzcGxheTogYmxvY2s7XHJcbiAgICBtYXJnaW46IDAgYXV0bztcclxuICB9Il19 */"

/***/ }),

/***/ "./src/app/projects/projects.page.ts":
/*!*******************************************!*\
  !*** ./src/app/projects/projects.page.ts ***!
  \*******************************************/
/*! exports provided: ProjectsPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectsPage", function() { return ProjectsPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_project_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../shared/project.service */ "./src/app/shared/project.service.ts");
/* harmony import */ var _shared_user_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../shared/user.service */ "./src/app/shared/user.service.ts");
/* harmony import */ var _ionic_native_toast_ngx__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic-native/toast/ngx */ "./node_modules/@ionic-native/toast/ngx/index.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _shared_sprint_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../shared/sprint.service */ "./src/app/shared/sprint.service.ts");
/* harmony import */ var _shared_tag_service__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../shared/tag.service */ "./src/app/shared/tag.service.ts");









var ProjectsPage = /** @class */ (function () {
    function ProjectsPage(projectService, sprintService, toast, toastController, tagService, userService) {
        this.projectService = projectService;
        this.sprintService = sprintService;
        this.toast = toast;
        this.toastController = toastController;
        this.tagService = tagService;
        this.userService = userService;
        this.isLoading = true;
    }
    ProjectsPage.prototype.ngOnInit = function () {
        this.resetForm();
        this.projectService.getAllProjects();
        this.sprintService.getAllSprints();
        this.tagService.getAllTags();
        this.isLoading = false;
    };
    ProjectsPage.prototype.presentToast = function (text, theme) {
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
    ProjectsPage.prototype.isMatch = function (array) {
        return this.userService.roleMatch(array);
    };
    ProjectsPage.prototype.showForEdit = function (prj) {
        this.projectService.selectedProject = Object.assign({}, prj);
        this.ScrollToTop();
    };
    ProjectsPage.prototype.ScrollToTop = function () {
        this.content.scrollToTop(800);
    };
    ProjectsPage.prototype.onDelete = function (id) {
        var _this = this;
        if (confirm('Are you sure to delete this record ?') == true) {
            this.projectService.deleteProject(id)
                .subscribe(function (x) {
                _this.projectService.getAllProjects();
                _this.presentToast('Project deleted!', 'danger');
            });
        }
    };
    ProjectsPage.prototype.deleteSprint = function (sprintId, project) {
        var _this = this;
        var index = project.sprints.findIndex(function (x) { return x.id == sprintId; });
        if (index > -1) {
            project.sprints.splice(index, 1);
        }
        this.projectService.putProject(sprintId, project).subscribe(function (data) {
            _this.presentToast('Sprint deleted!', 'danger');
        });
    };
    ProjectsPage.prototype.markSprintAsDone = function (id) {
        var _this = this;
        this.sprintService.markSprintAsDone(id).subscribe(function (data) {
            _this.projectService.getAllProjects();
            _this.presentToast('Sprint done!', 'success');
        });
    };
    ProjectsPage.prototype.compareFn = function (e1, e2) {
        return e1 && e2 ? e1.id === e2.id : e1 === e2;
    };
    ProjectsPage.prototype.resetForm = function (form) {
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
    ProjectsPage.prototype.onSubmit = function (form) {
        var _this = this;
        if (form.value.ID == null) {
            this.projectService.postProject(form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.projectService.getAllProjects();
                // this.toast.show(`New company add!`, '5000', 'center').subscribe(
                //   toast => {
                //     console.log(toast);
                //   }
                // );
                _this.presentToast('project created!', 'success');
            });
        }
        else {
            this.projectService.putProject(form.value.ID, form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.projectService.getAllProjects();
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
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])(_ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonContent"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonContent"])
    ], ProjectsPage.prototype, "content", void 0);
    ProjectsPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-projects',
            template: __webpack_require__(/*! ./projects.page.html */ "./src/app/projects/projects.page.html"),
            styles: [__webpack_require__(/*! ./projects.page.scss */ "./src/app/projects/projects.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_project_service__WEBPACK_IMPORTED_MODULE_2__["ProjectService"],
            _shared_sprint_service__WEBPACK_IMPORTED_MODULE_6__["SprintService"],
            _ionic_native_toast_ngx__WEBPACK_IMPORTED_MODULE_4__["Toast"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["ToastController"],
            _shared_tag_service__WEBPACK_IMPORTED_MODULE_7__["TagService"],
            _shared_user_service__WEBPACK_IMPORTED_MODULE_3__["UserService"]])
    ], ProjectsPage);
    return ProjectsPage;
}());



/***/ })

}]);
//# sourceMappingURL=projects-projects-module.js.map