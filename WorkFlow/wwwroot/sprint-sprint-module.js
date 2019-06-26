(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["sprint-sprint-module"],{

/***/ "./src/app/sprint/sprint.module.ts":
/*!*****************************************!*\
  !*** ./src/app/sprint/sprint.module.ts ***!
  \*****************************************/
/*! exports provided: SprintPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SprintPageModule", function() { return SprintPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _sprint_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./sprint.page */ "./src/app/sprint/sprint.page.ts");







var routes = [
    {
        path: '',
        component: _sprint_page__WEBPACK_IMPORTED_MODULE_6__["SprintPage"]
    }
];
var SprintPageModule = /** @class */ (function () {
    function SprintPageModule() {
    }
    SprintPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_sprint_page__WEBPACK_IMPORTED_MODULE_6__["SprintPage"]]
        })
    ], SprintPageModule);
    return SprintPageModule;
}());



/***/ }),

/***/ "./src/app/sprint/sprint.page.html":
/*!*****************************************!*\
  !*** ./src/app/sprint/sprint.page.html ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\n  <ion-toolbar>\n    <ion-title class=\"blue\">Спринт</ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content padding>\n  <ion-row justify-content-center>\n    <ion-col align-self-center size-md=\"9\" size-lg=\"9\" size-xs=\"12\">\n      <div>\n        <ion-card>\n          <ion-card-header>\n            <ion-card-title>\n              {{ sprint.name }}\n              <ion-icon *ngIf=\"sprint.isDone\" color=\"success\" name=\"checkmark-circle\"></ion-icon>\n            </ion-card-title>\n            <ion-card-subtitle>\n              <ion-button size=\"small\" color=\"primary\" (click)=\"showForEdit(sprint)\">\n                <ion-ripple-effect></ion-ripple-effect>\n                <ion-icon name=\"create\"></ion-icon>\n                Редактировать\n              </ion-button>\n              <ion-button size=\"small\" color=\"medium\" (click)=\"onDelete(sprint.id)\">\n                <ion-ripple-effect></ion-ripple-effect>\n                <ion-icon name=\"trash\"></ion-icon>\n                Удалить\n              </ion-button>\n              <br>\n              <br>\n              {{ sprint.startDate | date: \"dd/MM/yyyy\"}} - {{ sprint.endDate | date: \"dd/MM/yyyy\"}}\n              <br>\n              <br>\n            </ion-card-subtitle>\n          </ion-card-header>          \n          <ion-card-content>\n            {{ sprint.description }}\n            <br>\n            <br>\n            <div *ngFor=\"let project of sprint.projects\">\n              <ion-chip>\n                <ion-label>{{ project.name }}</ion-label>\n              </ion-chip>\n            </div>\n          </ion-card-content>          \n        </ion-card>\n      </div>\n    </ion-col>\n  </ion-row>\n</ion-content>\n"

/***/ }),

/***/ "./src/app/sprint/sprint.page.scss":
/*!*****************************************!*\
  !*** ./src/app/sprint/sprint.page.scss ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NwcmludC9zcHJpbnQucGFnZS5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/sprint/sprint.page.ts":
/*!***************************************!*\
  !*** ./src/app/sprint/sprint.page.ts ***!
  \***************************************/
/*! exports provided: SprintPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SprintPage", function() { return SprintPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_sprint_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../shared/sprint.service */ "./src/app/shared/sprint.service.ts");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _shared_project_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../shared/project.service */ "./src/app/shared/project.service.ts");



;




var SprintPage = /** @class */ (function () {
    function SprintPage(sprintService, router, route, toastController, alertController, projectService) {
        this.sprintService = sprintService;
        this.router = router;
        this.route = route;
        this.toastController = toastController;
        this.alertController = alertController;
        this.projectService = projectService;
    }
    SprintPage.prototype.ngOnInit = function () {
        this.projectService.getAllProjects();
    };
    SprintPage.prototype.presentToast = function (text, theme) {
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
    SprintPage.prototype.ionViewWillEnter = function () {
        var _this = this;
        this.id = this.route.snapshot.paramMap.get('id');
        this.sprintService.returnSprintById(this.id).subscribe(function (data) {
            _this.sprint = data;
            console.log(_this.sprint);
        });
    };
    SprintPage.prototype.showForEdit = function (spr) {
        this.sprintService.selectedSprint = Object.assign({}, spr);
        this.router.navigate(['/sprintform']);
    };
    SprintPage.prototype.onDelete = function (id) {
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
                                        _this.sprintService.deleteSprint(id)
                                            .subscribe(function (x) {
                                            _this.sprintService.getAllSprints();
                                            _this.presentToast('Sprint deleted!', 'danger');
                                            _this.router.navigate(['/sprints']);
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
    SprintPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-sprint',
            template: __webpack_require__(/*! ./sprint.page.html */ "./src/app/sprint/sprint.page.html"),
            styles: [__webpack_require__(/*! ./sprint.page.scss */ "./src/app/sprint/sprint.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_sprint_service__WEBPACK_IMPORTED_MODULE_2__["SprintService"],
            _angular_router__WEBPACK_IMPORTED_MODULE_4__["Router"],
            _angular_router__WEBPACK_IMPORTED_MODULE_4__["ActivatedRoute"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_3__["ToastController"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_3__["AlertController"],
            _shared_project_service__WEBPACK_IMPORTED_MODULE_5__["ProjectService"]])
    ], SprintPage);
    return SprintPage;
}());



/***/ })

}]);
//# sourceMappingURL=sprint-sprint-module.js.map