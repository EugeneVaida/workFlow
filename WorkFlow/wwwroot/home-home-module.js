(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["home-home-module"],{

/***/ "./src/app/home/home.module.ts":
/*!*************************************!*\
  !*** ./src/app/home/home.module.ts ***!
  \*************************************/
/*! exports provided: HomePageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HomePageModule", function() { return HomePageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _home_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./home.page */ "./src/app/home/home.page.ts");







var routes = [
    {
        path: '',
        component: _home_page__WEBPACK_IMPORTED_MODULE_6__["HomePage"]
    }
];
var HomePageModule = /** @class */ (function () {
    function HomePageModule() {
    }
    HomePageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_home_page__WEBPACK_IMPORTED_MODULE_6__["HomePage"]]
        })
    ], HomePageModule);
    return HomePageModule;
}());



/***/ }),

/***/ "./src/app/home/home.page.html":
/*!*************************************!*\
  !*** ./src/app/home/home.page.html ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\n  <ion-toolbar>\n    <ion-title><span class=\"blue\">Work</span><span class=\"pink\">Flow</span></ion-title>\n    <ion-buttons slot=\"end\">\n        <ion-button (click)=\"logout()\">Выйти</ion-button>\n    </ion-buttons>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content>\n  <div>\n    <ion-slides pager=\"true\">\n      <ion-slide class=\"step-three\">\n        <h1></h1>\n        <div text-center *ngIf=\"isMatch(['Admin'])\">\n          <h1>Hello {{ username }}</h1>\n          <h4>Menu for admin</h4>\n          <ion-button (click)=\"goToSprints()\">Go to sprints!</ion-button>\n          <ion-button (click)=\"goToTags()\">Go to tags!</ion-button>\n          <ion-button (click)=\"goToProjects()\">Go to projects!</ion-button>\n          <ion-button (click)=\"goToCompanies()\">Go to companies!</ion-button>\n          <ion-button (click)=\"goToUsers()\">Go to users!</ion-button>\n        </div>\n        <div text-center *ngIf=\"isMatch(['Manager'])\">\n          <h1>Hello {{ username }}</h1>\n          <h4>Menu for manager</h4>\n          <ion-button (click)=\"goToSprints()\">Go to sprints!</ion-button>\n          <ion-button (click)=\"goToTags()\">Go to tags!</ion-button>\n          <ion-button (click)=\"goToProjects()\">Go to projects!</ion-button>\n          <ion-button (click)=\"goToComments()\">Go to comments!</ion-button>\n        </div>\n\n      </ion-slide>\n\n      <ion-slide class=\"step-one\">\n        <ion-img src=\"/assets/slides/list.png\"></ion-img>\n        <h1>Sprints</h1>\n        <p>Text</p>\n        <ion-button (click)=\"goToSprints()\">Go to sprints!</ion-button>\n      </ion-slide>\n\n      <ion-slide class=\"step-two\">\n        <ion-img src=\"/assets/slides/project.png\"></ion-img>\n        <h1>Projects</h1>\n        <p>Text</p>\n        <ion-button (click)=\"goToProjects()\">Go to projects!</ion-button>\n      </ion-slide>\n\n      <ion-slide class=\"step-three\">\n        <ion-img src=\"/assets/slides/tag.png\"></ion-img>\n        <h1>Tags</h1>\n        <p>Text</p>\n        <ion-button (click)=\"goToTags()\">Go to tags!</ion-button>\n      </ion-slide>\n\n      <ion-slide class=\"step-three\">\n        <ion-img src=\"/assets/slides/companies.png\"></ion-img>\n        <h1>Companies</h1>\n        <p>Text</p>\n        <ion-button (click)=\"goToCompanies()\">Go to companies!</ion-button>\n      </ion-slide>\n    </ion-slides>\n  </div>\n</ion-content>\n\n<!-- <ion-tabs>\n      <ion-tab label=\"One\" icon=\"navigate\" href=\"/tabs/(one:one)\">\n        <ion-router-outlet name=\"one\"></ion-router-outlet>\n      </ion-tab>\n      <ion-tab label=\"Two\" icon=\"person\" href=\"/tabs/(two:two)\">\n        <ion-router-outlet name=\"two\"></ion-router-outlet>\n      </ion-tab>\n      <ion-tab label=\"Three\" icon=\"bookmarks\" href=\"/tabs/(three:three)\">\n        <ion-router-outlet name=\"three\"></ion-router-outlet>\n      </ion-tab>\n    </ion-tabs> -->\n"

/***/ }),

/***/ "./src/app/home/home.page.scss":
/*!*************************************!*\
  !*** ./src/app/home/home.page.scss ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "ion-slide {\n  height: 80vh;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n          flex-direction: column; }\n\nion-img {\n  padding: 30px; }\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvaG9tZS9EOlxccHJvamVjdHNcXFdvcmtGbG93Q2xpZW50XFx3b3JrRmxvdy9zcmNcXGFwcFxcaG9tZVxcaG9tZS5wYWdlLnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSxZQUFZO0VBQ1osNEJBQXNCO0VBQXRCLDZCQUFzQjtVQUF0QixzQkFBc0IsRUFBQTs7QUFJMUI7RUFDSSxhQUFhLEVBQUEiLCJmaWxlIjoic3JjL2FwcC9ob21lL2hvbWUucGFnZS5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiaW9uLXNsaWRlIHtcclxuICAgIGhlaWdodDogODB2aDtcclxuICAgIGZsZXgtZGlyZWN0aW9uOiBjb2x1bW47XHJcbn1cclxuXHJcblxyXG5pb24taW1nIHtcclxuICAgIHBhZGRpbmc6IDMwcHg7XHJcbn0iXX0= */"

/***/ }),

/***/ "./src/app/home/home.page.ts":
/*!***********************************!*\
  !*** ./src/app/home/home.page.ts ***!
  \***********************************/
/*! exports provided: HomePage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HomePage", function() { return HomePage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _shared_user_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../shared/user.service */ "./src/app/shared/user.service.ts");




var HomePage = /** @class */ (function () {
    function HomePage(router, userService) {
        this.router = router;
        this.userService = userService;
        this.sliderConfig = {
            slidesPerView: 1,
            spaceBetween: 10,
            centeredSlides: true
        };
    }
    HomePage.prototype.ngOnInit = function () {
        this.usersRoles = localStorage.getItem('userRoles').split(',');
        this.username = localStorage.getItem('userName');
    };
    HomePage.prototype.goToCompanies = function () {
        this.router.navigate(['/companies']);
    };
    HomePage.prototype.goToTags = function () {
        this.router.navigate(['/tags']);
    };
    HomePage.prototype.goToProjects = function () {
        this.router.navigate(['/projects']);
    };
    HomePage.prototype.goToSprints = function () {
        this.router.navigate(['/sprints']);
    };
    HomePage.prototype.goToUsers = function () {
        this.router.navigate(['/users']);
    };
    HomePage.prototype.isMatch = function (array) {
        return this.userService.roleMatch(array);
    };
    HomePage.prototype.logout = function () {
    };
    HomePage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-home',
            template: __webpack_require__(/*! ./home.page.html */ "./src/app/home/home.page.html"),
            styles: [__webpack_require__(/*! ./home.page.scss */ "./src/app/home/home.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"], _shared_user_service__WEBPACK_IMPORTED_MODULE_3__["UserService"]])
    ], HomePage);
    return HomePage;
}());



/***/ })

}]);
//# sourceMappingURL=home-home-module.js.map