(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["project-project-module"],{

/***/ "./src/app/project/project.module.ts":
/*!*******************************************!*\
  !*** ./src/app/project/project.module.ts ***!
  \*******************************************/
/*! exports provided: ProjectPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectPageModule", function() { return ProjectPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _project_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./project.page */ "./src/app/project/project.page.ts");







var routes = [
    {
        path: '',
        component: _project_page__WEBPACK_IMPORTED_MODULE_6__["ProjectPage"]
    }
];
var ProjectPageModule = /** @class */ (function () {
    function ProjectPageModule() {
    }
    ProjectPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_project_page__WEBPACK_IMPORTED_MODULE_6__["ProjectPage"]]
        })
    ], ProjectPageModule);
    return ProjectPageModule;
}());



/***/ }),

/***/ "./src/app/project/project.page.html":
/*!*******************************************!*\
  !*** ./src/app/project/project.page.html ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\r\n  <ion-toolbar>\r\n    <ion-buttons slot=\"start\">\r\n      <ion-back-button>\r\n      </ion-back-button>\r\n    </ion-buttons>\r\n    <ion-title class=\"blue\">Проект - {{ project.name }}</ion-title>\r\n  </ion-toolbar>\r\n</ion-header>\r\n<ion-content padding>\r\n    <ion-fab vertical=\"top\" horizontal=\"end\" edge slot=\"fixed\" (click)=\"invitation(project.id)\">\r\n      <ion-fab-button>\r\n        <ion-icon name=\"link\"></ion-icon>\r\n      </ion-fab-button>\r\n    </ion-fab>\r\n  <ion-row justify-content-center>\r\n    <ion-col align-self-center size-md=\"9\" size-lg=\"9\" size-xs=\"12\">\r\n      <div>\r\n        <ion-card>\r\n          <ion-card-header>\r\n            <ion-card-title>\r\n              <h1>\r\n                {{ project.name }}\r\n              </h1>\r\n            </ion-card-title>\r\n            <ion-card-subtitle>\r\n              <ion-button size=\"small\" color=\"primary\" (click)=\"showForEdit(project)\">\r\n                <ion-ripple-effect></ion-ripple-effect>\r\n                <ion-icon name=\"create\"></ion-icon>\r\n                Редактировать\r\n              </ion-button>\r\n              <ion-button size=\"small\" color=\"medium\" (click)=\"onDelete(project.id)\">\r\n                <ion-ripple-effect></ion-ripple-effect>\r\n                <ion-icon name=\"trash\"></ion-icon>\r\n                Удалить\r\n              </ion-button>\r\n              <br>\r\n              <br>\r\n              {{ project.startDate | date: \"dd/MM/yyyy\"}} - {{ project.endDate | date: \"dd/MM/yyyy\"}}\r\n              <br>\r\n              <br>         \r\n              <div *ngFor=\"let tag of project.tags\">\r\n                <ion-chip color=\"tertiary\" [routerLink]=\"'/tag-projects/' + tag.id\">\r\n                  <ion-label color=\"tertiary\">{{ tag.name }}</ion-label>\r\n                </ion-chip>\r\n              </div>\r\n            </ion-card-subtitle>\r\n          </ion-card-header>\r\n          <ion-card-content style=\"font-size: 18px;\">\r\n            {{ project.description }}\r\n            <br>\r\n            <br>\r\n            <br>\r\n\r\n            <ion-list>\r\n              <ion-list-header>\r\n                <ion-label>Спринты</ion-label>\r\n              </ion-list-header>\r\n              <ion-item-sliding *ngFor=\"let sprint of project.sprints\">\r\n                <ion-item-options side=\"start\">\r\n                  <ion-item-option color=\"danger\" (click)=\"deleteSprint(sprint.id, project)\">Delete</ion-item-option>\r\n                </ion-item-options>\r\n                <ion-item>\r\n                  <ion-label>{{ sprint.name }}</ion-label>\r\n                  <ion-icon *ngIf=\"sprint.isDone\" color=\"tertiary\" name=\"checkmark-circle\"></ion-icon>\r\n                </ion-item>\r\n                <ion-item-options side=\"end\">\r\n                  <ion-item-option color=\"warning\" (click)=\"markSprintAsDone(sprint.id, project.id)\">Done!\r\n                  </ion-item-option>\r\n                </ion-item-options>\r\n              </ion-item-sliding>\r\n            </ion-list>\r\n\r\n          </ion-card-content>\r\n        </ion-card>\r\n      </div>\r\n    </ion-col>\r\n  </ion-row>\r\n</ion-content>\r\n"

/***/ }),

/***/ "./src/app/project/project.page.scss":
/*!*******************************************!*\
  !*** ./src/app/project/project.page.scss ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Byb2plY3QvcHJvamVjdC5wYWdlLnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/project/project.page.ts":
/*!*****************************************!*\
  !*** ./src/app/project/project.page.ts ***!
  \*****************************************/
/*! exports provided: ProjectPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectPage", function() { return ProjectPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _shared_project_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../shared/project.service */ "./src/app/shared/project.service.ts");
/* harmony import */ var _shared_sprint_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../shared/sprint.service */ "./src/app/shared/sprint.service.ts");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");







var ProjectPage = /** @class */ (function () {
    function ProjectPage(route, projectService, toastController, alertController, router, sprintService) {
        this.route = route;
        this.projectService = projectService;
        this.toastController = toastController;
        this.alertController = alertController;
        this.router = router;
        this.sprintService = sprintService;
    }
    ProjectPage.prototype.ngOnInit = function () {
    };
    ProjectPage.prototype.ionViewWillEnter = function () {
        var _this = this;
        this.id = this.route.snapshot.paramMap.get('id');
        this.projectService.returnProjectById(this.id).subscribe(function (data) {
            _this.project = data;
            console.log(_this.project);
        });
    };
    ProjectPage.prototype.presentToast = function (text, theme) {
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
    ProjectPage.prototype.onDelete = function (id) {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
            var alert;
            var _this = this;
            return tslib__WEBPACK_IMPORTED_MODULE_0__["__generator"](this, function (_a) {
                switch (_a.label) {
                    case 0: return [4 /*yield*/, this.alertController.create({
                            header: 'Удаление',
                            message: 'Вы действительно хотите удалить проект?',
                            buttons: [
                                {
                                    text: 'Отменить',
                                    role: 'cancel',
                                    cssClass: 'secondary'
                                }, {
                                    text: 'Удалить',
                                    handler: function () {
                                        _this.projectService.deleteProject(id)
                                            .subscribe(function (x) {
                                            _this.projectService.getAllProjects();
                                            _this.router.navigate(['/projects']);
                                            _this.presentToast('Project deleted!', 'danger');
                                        });
                                    }
                                }
                            ]
                        })];
                    case 1:
                        alert = _a.sent();
                        return [4 /*yield*/, alert.present()];
                    case 2:
                        _a.sent();
                        return [2 /*return*/];
                }
            });
        });
    };
    ProjectPage.prototype.showForEdit = function (prj) {
        this.projectService.selectedProject = Object.assign({}, prj);
        this.router.navigate(['/projectform']);
    };
    ProjectPage.prototype.invitation = function (id) {
        console.log(id);
        this.projectService.projectInvitation(id);
        this.router.navigate(['/invite-link']);
    };
    ProjectPage.prototype.deleteSprint = function (sprintId, project) {
        var _this = this;
        var index = project.sprints.findIndex(function (x) { return x.id == sprintId; });
        if (index > -1) {
            project.sprints.splice(index, 1);
        }
        console.log(project);
        this.projectService.putProject(project.id, project).subscribe(function (data) {
            _this.presentToast('Sprint deleted!', 'danger');
        });
    };
    ProjectPage.prototype.markSprintAsDone = function (id) {
        var _this = this;
        this.sprintService.markSprintAsDone(id).subscribe(function (data) {
            _this.id = _this.route.snapshot.paramMap.get('id');
            _this.projectService.returnProjectById(_this.id).subscribe(function (data) {
                _this.project = data;
                console.log(_this.project);
            });
            _this.presentToast('Sprint done!', 'success');
        });
    };
    ProjectPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-project',
            template: __webpack_require__(/*! ./project.page.html */ "./src/app/project/project.page.html"),
            styles: [__webpack_require__(/*! ./project.page.scss */ "./src/app/project/project.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"],
            _shared_project_service__WEBPACK_IMPORTED_MODULE_3__["ProjectService"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["ToastController"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["AlertController"],
            _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"],
            _shared_sprint_service__WEBPACK_IMPORTED_MODULE_4__["SprintService"]])
    ], ProjectPage);
    return ProjectPage;
}());



/***/ })

}]);
//# sourceMappingURL=project-project-module.js.map