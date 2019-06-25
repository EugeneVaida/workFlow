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

module.exports = "<ion-header>\r\n  <ion-toolbar>\r\n    <ion-title>\r\n      <span class=\"blue\">Проекты</span>          \r\n    </ion-title>\r\n    \r\n  </ion-toolbar>\r\n</ion-header>\r\n\r\n<ion-content padding>\r\n    <ion-fab vertical=\"top\" horizontal=\"end\" edge slot=\"fixed\" (click)=\"createNew()\">\r\n        <ion-fab-button>\r\n          <ion-icon name=\"add\"></ion-icon>\r\n        </ion-fab-button>\r\n      </ion-fab>\r\n  <ion-spinner *ngIf=\"projectService.isLoad && tagService.isLoad && sprintService.isLoad\"></ion-spinner>\r\n  <!-- <div class=\"row\" *ngIf=\"!projectService.isLoad && !tagService.isLoad && !sprintService.isLoad\">\r\n    <div class=\"col s12 m4\">\r\n      <form (ngSubmit)=\"onSubmit(projectForm)\" #projectForm=\"ngForm\">\r\n        <ion-grid>\r\n          <ion-row justify-content-center>\r\n            <ion-col align-self-center size-md=\"6\" size-lg=\"5\" size-xs=\"12\">\r\n              <div text-center *ngIf=\"isMatch(['Manager'])\">                  \r\n                <h4>Project form </h4>\r\n              </div>\r\n              <div padding>\r\n                <input type=\"hidden\" name=\"ID\" #ID=\"ngModel\" [(ngModel)]=\"projectService.selectedProject.id\">\r\n                <ion-item>\r\n                  <ion-input type=\"text\" #name ngModel name=\"name\" [(ngModel)]=\"projectService.selectedProject.name\"\r\n                    placeholder=\"Название\" required></ion-input>\r\n                </ion-item>\r\n                <ion-item>\r\n                  <ion-datetime #startDate ngModel name=\"startDate\" placeholder=\"Начало\"\r\n                    [(ngModel)]=\"projectService.selectedProject.startDate\" display-format=\"DD/MM/YYYY\"\r\n                    picker-format=\"DD MM YYYY\"></ion-datetime>\r\n                </ion-item>\r\n\r\n                <ion-item>\r\n                  <ion-datetime #endDate ngModel name=\"endDate\" placeholder=\"Конец\"\r\n                    [(ngModel)]=\"projectService.selectedProject.endDate\" display-format=\"DD/MM/YYYY\"\r\n                    picker-format=\"DD MM YYYY\"></ion-datetime>\r\n                </ion-item>\r\n\r\n                <ion-item>\r\n                  <ion-textarea #description ngModel name=\"description\"\r\n                    [(ngModel)]=\"projectService.selectedProject.description\" placeholder=\"Описание\" required>\r\n                  </ion-textarea>\r\n                </ion-item>\r\n                <ion-item>\r\n                  <ion-label position=\"floating\">Выберите спринты</ion-label>\r\n                  <ion-select #sprints ngModel name=\"sprints\" [(ngModel)]=\"projectService.selectedProject.sprints\"\r\n                    multiple=\"true\" [compareWith]=\"compareFn\">\r\n                    <ion-select-option *ngFor=\"let sprint of sprintService.sprintsList\" [value]=\"sprint\">\r\n                      {{sprint.name}}\r\n                    </ion-select-option>\r\n                  </ion-select>\r\n                </ion-item>\r\n                <ion-item>\r\n                  <ion-label position=\"floating\">Выберите теги</ion-label>\r\n                  <ion-select #tags ngModel name=\"tags\" [(ngModel)]=\"projectService.selectedProject.tags\"\r\n                    multiple=\"true\" [compareWith]=\"compareFn\">\r\n                    <ion-select-option *ngFor=\"let tag of tagService.tagsList\" [value]=\"tag\">\r\n                      {{tag.name}}\r\n                    </ion-select-option>\r\n                  </ion-select>\r\n                </ion-item>\r\n              </div>\r\n              <div padding>\r\n                <ion-button color=\"light\" size=\"default\" type=\"submit\" expand=\"block\">Create</ion-button>\r\n                <ion-button color=\"dark\" size=\"default\" type=\"button\" expand=\"block\" (click)=\"resetForm(projectForm)\">\r\n                  Reset\r\n                </ion-button>\r\n              </div>\r\n            </ion-col>\r\n          </ion-row>\r\n        </ion-grid>\r\n      </form>\r\n    </div>\r\n  </div> -->\r\n  <br>\r\n  <ion-searchbar (ionInput)=\"search($event)\" placeholder=\"Поиск\"></ion-searchbar>\r\n  <ion-grid>\r\n    <ion-row justify-content-center>\r\n      <ion-col align-self-center size-md=\"4\" size-lg=\"4\" size-xs=\"12\"\r\n        *ngFor=\"let project of projectService.projectsList\">\r\n        <div>\r\n          <ion-card color=\"light shade\">\r\n            <ion-card-header>\r\n              <ion-card-title>{{ project.name }}</ion-card-title>\r\n              <ion-card-subtitle>\r\n                {{ project.startDate | date: \"dd/MM/yyyy\"}} - {{ project.endDate | date: \"dd/MM/yyyy\"}}\r\n              </ion-card-subtitle>\r\n            </ion-card-header>\r\n\r\n            <ion-card-content>  \r\n              <span *ngFor=\"let tag of project.tags\">\r\n                <ion-chip [routerLink]=\"'/tag-projects/' + tag.id\" color=\"tertiary\">\r\n                  <ion-label color=\"tertiary\">{{ tag.name }}</ion-label>\r\n                </ion-chip>\r\n              </span>\r\n              <br>\r\n              <ion-button color=\"primary\" [routerLink]=\"'/project/' + project.id\">\r\n                <ion-ripple-effect></ion-ripple-effect>\r\n                <ion-icon name=\"arrow-forward\" slot=\"start\"></ion-icon>\r\n                Открыть\r\n              </ion-button>              \r\n            </ion-card-content>\r\n          </ion-card>\r\n        </div>\r\n      </ion-col>\r\n    </ion-row>\r\n  </ion-grid>\r\n</ion-content>"

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
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");










var ProjectsPage = /** @class */ (function () {
    function ProjectsPage(projectService, sprintService, toast, toastController, tagService, userService, router) {
        this.projectService = projectService;
        this.sprintService = sprintService;
        this.toast = toast;
        this.toastController = toastController;
        this.tagService = tagService;
        this.userService = userService;
        this.router = router;
        this.isLoading = true;
    }
    ProjectsPage.prototype.ngOnInit = function () {
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
    ProjectsPage.prototype.search = function (ev) {
        var val = ev.target.value;
        if (val && val.trim() != '') {
            this.projectService.searchProjects(val);
        }
        else {
            this.projectService.getAllProjects();
        }
    };
    ProjectsPage.prototype.createNew = function () {
        this.projectService.selectedProject = {
            id: null,
            name: '',
            description: '',
            startDate: '',
            endDate: '',
            sprints: [],
            tags: []
        };
        this.router.navigateByUrl("/projectform");
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
            _shared_user_service__WEBPACK_IMPORTED_MODULE_3__["UserService"],
            _angular_router__WEBPACK_IMPORTED_MODULE_8__["Router"]])
    ], ProjectsPage);
    return ProjectsPage;
}());



/***/ })

}]);
//# sourceMappingURL=projects-projects-module.js.map