(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["tags-tags-module"],{

/***/ "./src/app/tags/tags.module.ts":
/*!*************************************!*\
  !*** ./src/app/tags/tags.module.ts ***!
  \*************************************/
/*! exports provided: TagsPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TagsPageModule", function() { return TagsPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");
/* harmony import */ var _tags_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./tags.page */ "./src/app/tags/tags.page.ts");







var routes = [
    {
        path: '',
        component: _tags_page__WEBPACK_IMPORTED_MODULE_6__["TagsPage"]
    }
];
var TagsPageModule = /** @class */ (function () {
    function TagsPageModule() {
    }
    TagsPageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _ionic_angular__WEBPACK_IMPORTED_MODULE_5__["IonicModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forChild(routes)
            ],
            declarations: [_tags_page__WEBPACK_IMPORTED_MODULE_6__["TagsPage"]]
        })
    ], TagsPageModule);
    return TagsPageModule;
}());



/***/ }),

/***/ "./src/app/tags/tags.page.html":
/*!*************************************!*\
  !*** ./src/app/tags/tags.page.html ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<ion-header>\n  <ion-toolbar>\n    <ion-title><span class=\"blue\">Tags</span></ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content padding >\n  <div class=\"row\">\n    <div class=\"col s12 m4\">\n      <form (ngSubmit)=\"onSubmit(tagForm)\" #tagForm=\"ngForm\">\n        <ion-grid>\n          <ion-row justify-content-center>\n            <ion-col align-self-center size-md=\"6\" size-lg=\"5\" size-xs=\"12\">\n              <div text-center>\n                <h4>Tag form</h4>\n              </div>\n              <div padding>\n                <input type=\"hidden\" name=\"ID\" #ID=\"ngModel\" [(ngModel)]=\"tagService.selectedTag.id\">\n                <ion-item>\n                  <ion-input type=\"text\" #name ngModel name=\"name\" [(ngModel)]=\"tagService.selectedTag.name\"\n                    placeholder=\"Название\" required></ion-input>\n                </ion-item>              \n                                \n              </div>\n              <div padding>\n                <ion-button color=\"light\" size=\"default\" type=\"submit\" expand=\"block\">Create</ion-button>\n                <ion-button color=\"dark\" size=\"default\" type=\"button\" expand=\"block\" (click)=\"resetForm(tagForm)\">\n                  Reset\n                </ion-button>\n              </div>\n            </ion-col>\n          </ion-row>\n        </ion-grid>\n      </form>\n    </div>\n  </div>\n  <ion-row justify-content-center>\n    <ion-col align-self-center size-md=\"4\" size-lg=\"4\" size-xs=\"12\">\n        <ion-list *ngFor=\"let tag of tagService.tagsList\">\n            <ion-item-sliding>\n              <ion-item-options side=\"start\">\n                <ion-item-option color=\"danger\" (click)=\"onDelete(tag.id)\">Delete</ion-item-option>\n              </ion-item-options>\n              <ion-item>\n                <ion-label>{{ tag.name }}</ion-label>                \n              </ion-item>\n              <ion-item-options side=\"end\">\n                <ion-item-option color=\"warning\" (click)=\"showForEdit(tag)\">Change</ion-item-option>\n              </ion-item-options>\n            </ion-item-sliding>\n          </ion-list>\n    </ion-col>\n  </ion-row>\n</ion-content>"

/***/ }),

/***/ "./src/app/tags/tags.page.scss":
/*!*************************************!*\
  !*** ./src/app/tags/tags.page.scss ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3RhZ3MvdGFncy5wYWdlLnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/tags/tags.page.ts":
/*!***********************************!*\
  !*** ./src/app/tags/tags.page.ts ***!
  \***********************************/
/*! exports provided: TagsPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TagsPage", function() { return TagsPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_tag_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../shared/tag.service */ "./src/app/shared/tag.service.ts");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @ionic/angular */ "./node_modules/@ionic/angular/dist/fesm5.js");




var TagsPage = /** @class */ (function () {
    function TagsPage(tagService, toastController) {
        this.tagService = tagService;
        this.toastController = toastController;
    }
    TagsPage.prototype.presentToast = function (text, theme) {
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
    TagsPage.prototype.ngOnInit = function () {
        this.tagService.getAllTags();
        this.resetForm();
    };
    TagsPage.prototype.showForEdit = function (tg) {
        this.tagService.selectedTag = Object.assign({}, tg);
        this.ScrollToTop();
    };
    TagsPage.prototype.ScrollToTop = function () {
        this.content.scrollToTop(800);
    };
    TagsPage.prototype.onDelete = function (id) {
        var _this = this;
        if (confirm('Are you sure to delete this tag ?') == true) {
            this.tagService.deleteTag(id)
                .subscribe(function (x) {
                _this.tagService.getAllTags();
                _this.presentToast('Tag deleted!', 'danger');
            });
        }
    };
    TagsPage.prototype.resetForm = function (form) {
        if (form != null) {
            form.reset();
        }
        this.tagService.selectedTag = {
            id: null,
            name: ''
        };
    };
    TagsPage.prototype.onSubmit = function (form) {
        var _this = this;
        if (form.value.ID == null) {
            this.tagService.postSprint(form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.tagService.getAllTags();
                _this.presentToast('Tag created!', 'success');
            });
        }
        else {
            this.tagService.putTag(form.value.ID, form.value).subscribe(function (data) {
                _this.resetForm(form);
                _this.tagService.getAllTags();
                _this.presentToast('Tag updated!', 'success');
            });
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])(_ionic_angular__WEBPACK_IMPORTED_MODULE_3__["IonContent"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _ionic_angular__WEBPACK_IMPORTED_MODULE_3__["IonContent"])
    ], TagsPage.prototype, "content", void 0);
    TagsPage = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-tags',
            template: __webpack_require__(/*! ./tags.page.html */ "./src/app/tags/tags.page.html"),
            styles: [__webpack_require__(/*! ./tags.page.scss */ "./src/app/tags/tags.page.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_tag_service__WEBPACK_IMPORTED_MODULE_2__["TagService"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_3__["ToastController"]])
    ], TagsPage);
    return TagsPage;
}());



/***/ })

}]);
//# sourceMappingURL=tags-tags-module.js.map