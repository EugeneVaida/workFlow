(window.webpackJsonp=window.webpackJsonp||[]).push([[17],{"f+ep":function(l,n,u){"use strict";u.r(n);var e=u("CcnG"),i=function(){return function(){}}(),r=u("pMnS"),t=u("oBZk"),o=u("ZZ/e"),s=u("gIcY"),b=u("Ip0R"),a=u("CcaC"),g=function(){function l(l,n,u,e){this.userService=l,this.router=n,this.navCtrl=u,this.menu=e,this.isLoginError=!1,this.isLogging=!1,this.loginCredentials={UserName:"",Password:""}}return l.prototype.onSubmit=function(){var l=this;this.isLoginError=!1,this.isLogging=!0,this.userService.userAuthentication(this.loginCredentials.UserName,this.loginCredentials.Password).subscribe(function(n){localStorage.setItem("userToken",n.access_token),localStorage.setItem("userRoles",n.role),localStorage.setItem("userId",n.userId),l.isLogging=!1,l.router.navigate(["/projects"])},function(n){l.isLogging=!1,l.isLoginError=!0})},l}(),d=u("ZYCi"),c=e.ob({encapsulation:0,styles:[[".red-text[_ngcontent-%COMP%]{color:#bb5252;font-weight:700}ion-spinner[_ngcontent-%COMP%]{display:block;margin:0 auto}"]],data:{}});function p(l){return e.Jb(0,[(l()(),e.qb(0,0,null,null,1,"ion-spinner",[],null,null,null,t.Bb,t.K)),e.pb(1,49152,null,0,o.qb,[e.h,e.k],null,null)],null,null)}function h(l){return e.Jb(0,[(l()(),e.qb(0,0,null,null,1,"div",[["class","red-text error-message"],["text-center",""]],null,null,null,null,null)),(l()(),e.Hb(-1,null,[" Incorrect Username or Password "]))],null,null)}function m(l){return e.Jb(0,[(l()(),e.qb(0,0,null,null,46,"ion-content",[["class","login-content"],["padding",""]],null,null,null,t.db,t.m)),e.pb(1,49152,null,0,o.t,[e.h,e.k],null,null),(l()(),e.qb(2,0,null,0,44,"form",[["novalidate",""]],[[2,"ng-untouched",null],[2,"ng-touched",null],[2,"ng-pristine",null],[2,"ng-dirty",null],[2,"ng-valid",null],[2,"ng-invalid",null],[2,"ng-pending",null]],[[null,"ngSubmit"],[null,"submit"],[null,"reset"]],function(l,n,u){var i=!0,r=l.component;return"submit"===n&&(i=!1!==e.Ab(l,4).onSubmit(u)&&i),"reset"===n&&(i=!1!==e.Ab(l,4).onReset()&&i),"ngSubmit"===n&&(i=!1!==r.onSubmit()&&i),i},null,null)),e.pb(3,16384,null,0,s.n,[],null,null),e.pb(4,4210688,[["registerForm",4]],0,s.j,[[8,null],[8,null]],null,{ngSubmit:"ngSubmit"}),e.Eb(2048,null,s.b,null,[s.j]),e.pb(6,16384,null,0,s.i,[[4,s.b]],null,null),(l()(),e.qb(7,0,null,null,39,"ion-grid",[],null,null,null,t.hb,t.q)),e.pb(8,49152,null,0,o.z,[e.h,e.k],null,null),(l()(),e.qb(9,0,null,0,37,"ion-row",[["justify-content-center",""]],null,null,null,t.vb,t.E)),e.pb(10,49152,null,0,o.hb,[e.h,e.k],null,null),(l()(),e.qb(11,0,null,0,35,"ion-col",[["align-self-center",""],["size-lg","5"],["size-md","6"],["size-xs","12"]],null,null,null,t.cb,t.l)),e.pb(12,49152,null,0,o.s,[e.h,e.k],null,null),(l()(),e.qb(13,0,null,0,2,"div",[["text-center",""]],null,null,null,null,null)),(l()(),e.qb(14,0,null,null,1,"h4",[],null,null,null,null,null)),(l()(),e.Hb(-1,null,["Login Form"])),(l()(),e.qb(16,0,null,0,22,"div",[["padding",""]],null,null,null,null,null)),(l()(),e.qb(17,0,null,null,10,"ion-item",[],null,null,null,t.pb,t.v)),e.pb(18,49152,null,0,o.G,[e.h,e.k],null,null),(l()(),e.qb(19,0,null,0,8,"ion-input",[["name","UserName"],["placeholder","UserName"],["required",""],["type","text"]],[[1,"required",0],[2,"ng-untouched",null],[2,"ng-touched",null],[2,"ng-pristine",null],[2,"ng-dirty",null],[2,"ng-valid",null],[2,"ng-invalid",null],[2,"ng-pending",null]],[[null,"ngModelChange"],[null,"ionBlur"],[null,"ionChange"]],function(l,n,u){var i=!0,r=l.component;return"ionBlur"===n&&(i=!1!==e.Ab(l,21)._handleBlurEvent()&&i),"ionChange"===n&&(i=!1!==e.Ab(l,21)._handleInputEvent(u.target.value)&&i),"ngModelChange"===n&&(i=!1!==(r.loginCredentials.UserName=u)&&i),i},t.lb,t.u)),e.pb(20,49152,null,0,o.F,[e.h,e.k],{name:[0,"name"],placeholder:[1,"placeholder"],required:[2,"required"],type:[3,"type"]},null),e.pb(21,16384,null,0,o.Lb,[e.k],null,null),e.pb(22,16384,null,0,s.l,[],{required:[0,"required"]},null),e.Eb(1024,null,s.e,function(l){return[l]},[s.l]),e.Eb(1024,null,s.f,function(l){return[l]},[o.Lb]),e.pb(25,671744,null,0,s.k,[[2,s.b],[6,s.e],[8,null],[6,s.f]],{name:[0,"name"],model:[1,"model"]},{update:"ngModelChange"}),e.Eb(2048,null,s.g,null,[s.k]),e.pb(27,16384,null,0,s.h,[[4,s.g]],null,null),(l()(),e.qb(28,0,null,null,10,"ion-item",[],null,null,null,t.pb,t.v)),e.pb(29,49152,null,0,o.G,[e.h,e.k],null,null),(l()(),e.qb(30,0,null,0,8,"ion-input",[["name","Password"],["placeholder","Password"],["required",""],["type","password"]],[[1,"required",0],[2,"ng-untouched",null],[2,"ng-touched",null],[2,"ng-pristine",null],[2,"ng-dirty",null],[2,"ng-valid",null],[2,"ng-invalid",null],[2,"ng-pending",null]],[[null,"ngModelChange"],[null,"ionBlur"],[null,"ionChange"]],function(l,n,u){var i=!0,r=l.component;return"ionBlur"===n&&(i=!1!==e.Ab(l,32)._handleBlurEvent()&&i),"ionChange"===n&&(i=!1!==e.Ab(l,32)._handleInputEvent(u.target.value)&&i),"ngModelChange"===n&&(i=!1!==(r.loginCredentials.Password=u)&&i),i},t.lb,t.u)),e.pb(31,49152,null,0,o.F,[e.h,e.k],{name:[0,"name"],placeholder:[1,"placeholder"],required:[2,"required"],type:[3,"type"]},null),e.pb(32,16384,null,0,o.Lb,[e.k],null,null),e.pb(33,16384,null,0,s.l,[],{required:[0,"required"]},null),e.Eb(1024,null,s.e,function(l){return[l]},[s.l]),e.Eb(1024,null,s.f,function(l){return[l]},[o.Lb]),e.pb(36,671744,null,0,s.k,[[2,s.b],[6,s.e],[8,null],[6,s.f]],{name:[0,"name"],model:[1,"model"]},{update:"ngModelChange"}),e.Eb(2048,null,s.g,null,[s.k]),e.pb(38,16384,null,0,s.h,[[4,s.g]],null,null),(l()(),e.qb(39,0,null,0,3,"div",[["padding",""]],null,null,null,null,null)),(l()(),e.qb(40,0,null,null,2,"ion-button",[["expand","block"],["size","large"],["type","submit"]],null,null,null,t.U,t.d)),e.pb(41,49152,null,0,o.j,[e.h,e.k],{expand:[0,"expand"],size:[1,"size"],type:[2,"type"]},null),(l()(),e.Hb(-1,0,["Login"])),(l()(),e.hb(16777216,null,0,1,null,p)),e.pb(44,16384,null,0,b.j,[e.P,e.M],{ngIf:[0,"ngIf"]},null),(l()(),e.hb(16777216,null,0,1,null,h)),e.pb(46,16384,null,0,b.j,[e.P,e.M],{ngIf:[0,"ngIf"]},null)],function(l,n){var u=n.component;l(n,20,0,"UserName","UserName","","text"),l(n,22,0,""),l(n,25,0,"UserName",u.loginCredentials.UserName),l(n,31,0,"Password","Password","","password"),l(n,33,0,""),l(n,36,0,"Password",u.loginCredentials.Password),l(n,41,0,"block","large","submit"),l(n,44,0,u.userService.isLogging),l(n,46,0,u.isLoginError)},function(l,n){l(n,2,0,e.Ab(n,6).ngClassUntouched,e.Ab(n,6).ngClassTouched,e.Ab(n,6).ngClassPristine,e.Ab(n,6).ngClassDirty,e.Ab(n,6).ngClassValid,e.Ab(n,6).ngClassInvalid,e.Ab(n,6).ngClassPending),l(n,19,0,e.Ab(n,22).required?"":null,e.Ab(n,27).ngClassUntouched,e.Ab(n,27).ngClassTouched,e.Ab(n,27).ngClassPristine,e.Ab(n,27).ngClassDirty,e.Ab(n,27).ngClassValid,e.Ab(n,27).ngClassInvalid,e.Ab(n,27).ngClassPending),l(n,30,0,e.Ab(n,33).required?"":null,e.Ab(n,38).ngClassUntouched,e.Ab(n,38).ngClassTouched,e.Ab(n,38).ngClassPristine,e.Ab(n,38).ngClassDirty,e.Ab(n,38).ngClassValid,e.Ab(n,38).ngClassInvalid,e.Ab(n,38).ngClassPending)})}function C(l){return e.Jb(0,[(l()(),e.qb(0,0,null,null,1,"app-login",[],null,null,null,m,c)),e.pb(1,49152,null,0,g,[a.a,d.n,o.Gb,o.Eb],null,null)],null,null)}var v=e.mb("app-login",g,C,{},{},[]);u.d(n,"LoginPageModuleNgFactory",function(){return f});var f=e.nb(i,[],function(l){return e.xb([e.yb(512,e.j,e.cb,[[8,[r.a,v]],[3,e.j],e.y]),e.yb(4608,b.l,b.k,[e.v,[2,b.r]]),e.yb(4608,o.b,o.b,[e.A,e.g]),e.yb(4608,o.Fb,o.Fb,[o.b,e.j,e.r,b.c]),e.yb(4608,o.Ib,o.Ib,[o.b,e.j,e.r,b.c]),e.yb(4608,s.o,s.o,[]),e.yb(1073742336,b.b,b.b,[]),e.yb(1073742336,o.Cb,o.Cb,[]),e.yb(1073742336,s.m,s.m,[]),e.yb(1073742336,s.d,s.d,[]),e.yb(1073742336,d.p,d.p,[[2,d.v],[2,d.n]]),e.yb(1073742336,i,i,[]),e.yb(1024,d.l,function(){return[[{path:"",component:g}]]},[])])})}}]);