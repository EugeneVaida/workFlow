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

module.exports = "<ion-header>\n    <ion-toolbar>\n      <ion-title>{{ project.name }}</ion-title>\n    </ion-toolbar>\n  </ion-header>\n  <ion-content padding>\n    <ion-row justify-content-center>\n      <ion-col align-self-center size-md=\"4\" size-lg=\"4\" size-xs=\"12\">\n        <div>\n          <ion-card>\n            <ion-card-header>\n              <ion-card-title>{{ project.name }}</ion-card-title>\n              <ion-card-subtitle>\n                {{ project.startDate | date: \"dd/MM/yyyy\"}} - {{ project.endDate | date: \"dd/MM/yyyy\"}}\n              </ion-card-subtitle>\n            </ion-card-header>\n  \n            <ion-card-content>\n              {{ project.description }}\n              <ion-list *ngFor=\"let sprint of project.sprints\">\n                <ion-item-sliding>\n                  <ion-item-options side=\"start\">\n                    <ion-item-option color=\"danger\" (click)=\"deleteSprint(sprint.id, project)\">Delete</ion-item-option>\n                  </ion-item-options>\n                  <ion-item>\n                    <ion-label>{{ sprint.name }}</ion-label>\n                    <ion-icon *ngIf=\"sprint.isDone\" color=\"tertiary\" name=\"checkmark-circle\"></ion-icon>\n                  </ion-item>\n                  <ion-item-options side=\"end\">\n                    <ion-item-option color=\"warning\" (click)=\"markSprintAsDone(sprint.id, project.id)\">Done!\n                    </ion-item-option>\n                  </ion-item-options>\n                </ion-item-sliding>\n              </ion-list>\n  \n              <div *ngFor=\"let tag of project.tags\">\n                <ion-chip color=\"tertiary\" [routerLink]=\"'/tag-projects/' + tag.id\">\n                  <ion-label color=\"tertiary\">{{ tag.name }}</ion-label>\n                </ion-chip>\n              </div>\n            </ion-card-content>\n            <ion-item>\n              <ion-button color=\"medium\" (click)=\"onDelete(project.id)\">\n                <ion-ripple-effect></ion-ripple-effect>\n                <ion-icon name=\"trash\" slot=\"start\"></ion-icon>\n                Remove\n              </ion-button>\n              <ion-button color=\"light\" (click)=\"showForEdit(project)\">\n                <ion-ripple-effect></ion-ripple-effect>\n                <ion-icon name=\"create\" slot=\"start\"></ion-icon>\n                Edit\n              </ion-button>\n            </ion-item>\n          </ion-card>\n        </div>\n      </ion-col>\n    </ion-row>\n  </ion-content>\n"

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




var ProjectPage = /** @class */ (function () {
    function ProjectPage(route, projectService) {
        this.route = route;
        this.projectService = projectService;
    }
    ProjectPage.prototype.ngOnInit = function () {
        var _this = this;
        this.id = this.route.snapshot.paramMap.get('id');
        this.projectService.returnProjectById(this.id).subscribe(function (data) {
            _this.project = data;
            console.log(_this.project);
        });
    };
    ProjectPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-project',
            template: __webpack_require__(/*! ./project.page.html */ "./src/app/project/project.page.html"),
            styles: [__webpack_require__(/*! ./project.page.scss */ "./src/app/project/project.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"],
            _shared_project_service__WEBPACK_IMPORTED_MODULE_3__["ProjectService"]])
    ], ProjectPage);
    return ProjectPage;
}());



/***/ })

}]);
//# sourceMappingURL=project-project-module.js.map