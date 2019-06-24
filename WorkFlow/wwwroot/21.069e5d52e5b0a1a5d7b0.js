(window.webpackJsonp=window.webpackJsonp||[]).push([[21],{CedQ:function(l,n,t){"use strict";t.r(n);var u=t("CcnG"),e=t("mrSG"),o=t("g5XG"),r=t("CcaC"),i=t("peYo"),c=t("ZZ/e"),b=t("afav"),a=t("IgbF"),p=function(){function l(l,n,t,u,e,o,r){this.projectService=l,this.sprintService=n,this.toast=t,this.toastController=u,this.tagService=e,this.userService=o,this.router=r,this.isLoading=!0}return l.prototype.ngOnInit=function(){this.projectService.getAllProjects(),this.sprintService.getAllSprints(),this.tagService.getAllTags(),this.isLoading=!1},l.prototype.presentToast=function(l,n){return e.b(this,void 0,void 0,function(){return e.e(this,function(t){switch(t.label){case 0:return[4,this.toastController.create({message:l,showCloseButton:!0,duration:2e3,position:"top",closeButtonText:"Done",color:n})];case 1:return t.sent().present(),[2]}})})},l.prototype.isMatch=function(l){return this.userService.roleMatch(l)},l.prototype.showForEdit=function(l){this.projectService.selectedProject=Object.assign({},l),this.ScrollToTop()},l.prototype.ScrollToTop=function(){this.content.scrollToTop(800)},l.prototype.onDelete=function(l){var n=this;1==confirm("Are you sure to delete this record ?")&&this.projectService.deleteProject(l).subscribe(function(l){n.projectService.getAllProjects(),n.presentToast("Project deleted!","danger")})},l.prototype.deleteSprint=function(l,n){var t=this,u=n.sprints.findIndex(function(n){return n.id==l});u>-1&&n.sprints.splice(u,1),this.projectService.putProject(l,n).subscribe(function(l){t.presentToast("Sprint deleted!","danger")})},l.prototype.markSprintAsDone=function(l){var n=this;this.sprintService.markSprintAsDone(l).subscribe(function(l){n.projectService.getAllProjects(),n.presentToast("Sprint done!","success")})},l.prototype.search=function(l){var n=l.target.value;n&&""!=n.trim()?this.projectService.searchProjects(n):this.projectService.getAllProjects()},l.prototype.createNew=function(){this.projectService.selectedProject={id:null,name:"",description:"",startDate:"",endDate:"",sprints:[],tags:[]},this.router.navigateByUrl("/projectform")},l}(),s=function(){return function(){}}(),h=t("pMnS"),d=t("oBZk"),f=t("ZYCi"),k=t("Ip0R"),v=t("gIcY"),g=u.ob({encapsulation:0,styles:[["ion-spinner[_ngcontent-%COMP%]{display:block;margin:0 auto}"]],data:{}});function y(l){return u.Jb(0,[(l()(),u.qb(0,0,null,null,1,"ion-spinner",[],null,null,null,d.Bb,d.K)),u.pb(1,49152,null,0,c.qb,[u.h,u.k],null,null)],null,null)}function j(l){return u.Jb(0,[(l()(),u.qb(0,0,null,null,7,"span",[],null,null,null,null,null)),(l()(),u.qb(1,0,null,null,6,"ion-chip",[["color","tertiary"]],null,[[null,"click"]],function(l,n,t){var e=!0;return"click"===n&&(e=!1!==u.Ab(l,3).onClick()&&e),"click"===n&&(e=!1!==u.Ab(l,4).onClick(t)&&e),e},d.bb,d.k)),u.pb(2,49152,null,0,c.r,[u.h,u.k],{color:[0,"color"]},null),u.pb(3,16384,null,0,f.o,[f.n,f.a,[8,null],u.E,u.k],{routerLink:[0,"routerLink"]},null),u.pb(4,737280,null,0,c.Jb,[k.h,c.Gb,u.k,f.n,[2,f.o]],null,null),(l()(),u.qb(5,0,null,0,2,"ion-label",[["color","tertiary"]],null,null,null,d.qb,d.z)),u.pb(6,49152,null,0,c.M,[u.h,u.k],{color:[0,"color"]},null),(l()(),u.Hb(7,0,["",""]))],function(l,n){l(n,2,0,"tertiary"),l(n,3,0,"/tag-projects/"+n.context.$implicit.id),l(n,4,0),l(n,6,0,"tertiary")},function(l,n){l(n,7,0,n.context.$implicit.name)})}function m(l){return u.Jb(0,[(l()(),u.qb(0,0,null,null,28,"ion-col",[["align-self-center",""],["size-lg","4"],["size-md","4"],["size-xs","12"]],null,null,null,d.cb,d.l)),u.pb(1,49152,null,0,c.s,[u.h,u.k],null,null),(l()(),u.qb(2,0,null,0,26,"div",[],null,null,null,null,null)),(l()(),u.qb(3,0,null,null,25,"ion-card",[["color","light shade"]],null,null,null,d.ab,d.f)),u.pb(4,49152,null,0,c.l,[u.h,u.k],{color:[0,"color"]},null),(l()(),u.qb(5,0,null,0,9,"ion-card-header",[],null,null,null,d.X,d.h)),u.pb(6,49152,null,0,c.n,[u.h,u.k],null,null),(l()(),u.qb(7,0,null,0,2,"ion-card-title",[],null,null,null,d.Z,d.j)),u.pb(8,49152,null,0,c.p,[u.h,u.k],null,null),(l()(),u.Hb(9,0,["",""])),(l()(),u.qb(10,0,null,0,4,"ion-card-subtitle",[],null,null,null,d.Y,d.i)),u.pb(11,49152,null,0,c.o,[u.h,u.k],null,null),(l()(),u.Hb(12,0,[" "," - "," "])),u.Db(13,2),u.Db(14,2),(l()(),u.qb(15,0,null,0,13,"ion-card-content",[],null,null,null,d.W,d.g)),u.pb(16,49152,null,0,c.m,[u.h,u.k],null,null),(l()(),u.hb(16777216,null,0,1,null,j)),u.pb(18,278528,null,0,k.i,[u.P,u.M,u.t],{ngForOf:[0,"ngForOf"]},null),(l()(),u.qb(19,0,null,0,0,"br",[],null,null,null,null,null)),(l()(),u.qb(20,0,null,0,8,"ion-button",[["color","primary"]],null,[[null,"click"]],function(l,n,t){var e=!0;return"click"===n&&(e=!1!==u.Ab(l,22).onClick()&&e),"click"===n&&(e=!1!==u.Ab(l,23).onClick(t)&&e),e},d.U,d.d)),u.pb(21,49152,null,0,c.j,[u.h,u.k],{color:[0,"color"]},null),u.pb(22,16384,null,0,f.o,[f.n,f.a,[8,null],u.E,u.k],{routerLink:[0,"routerLink"]},null),u.pb(23,737280,null,0,c.Jb,[k.h,c.Gb,u.k,f.n,[2,f.o]],null,null),(l()(),u.qb(24,0,null,0,1,"ion-ripple-effect",[],null,null,null,d.ub,d.D)),u.pb(25,49152,null,0,c.fb,[u.h,u.k],null,null),(l()(),u.qb(26,0,null,0,1,"ion-icon",[["name","arrow-forward"],["slot","start"]],null,null,null,d.jb,d.s)),u.pb(27,49152,null,0,c.B,[u.h,u.k],{name:[0,"name"]},null),(l()(),u.Hb(-1,0,[" \u041e\u0442\u043a\u0440\u044b\u0442\u044c "]))],function(l,n){l(n,4,0,"light shade"),l(n,18,0,n.context.$implicit.tags),l(n,21,0,"primary"),l(n,22,0,"/project/"+n.context.$implicit.id),l(n,23,0),l(n,27,0,"arrow-forward")},function(l,n){l(n,9,0,n.context.$implicit.name);var t=u.Ib(n,12,0,l(n,13,0,u.Ab(n.parent,0),n.context.$implicit.startDate,"dd/MM/yyyy")),e=u.Ib(n,12,1,l(n,14,0,u.Ab(n.parent,0),n.context.$implicit.endDate,"dd/MM/yyyy"));l(n,12,0,t,e)})}function q(l){return u.Jb(0,[u.Cb(0,k.d,[u.v]),u.Fb(402653184,1,{content:0}),(l()(),u.qb(2,0,null,null,7,"ion-header",[],null,null,null,d.ib,d.r)),u.pb(3,49152,null,0,c.A,[u.h,u.k],null,null),(l()(),u.qb(4,0,null,0,5,"ion-toolbar",[],null,null,null,d.Hb,d.Q)),u.pb(5,49152,null,0,c.Ab,[u.h,u.k],null,null),(l()(),u.qb(6,0,null,0,3,"ion-title",[],null,null,null,d.Gb,d.P)),u.pb(7,49152,null,0,c.yb,[u.h,u.k],null,null),(l()(),u.qb(8,0,null,0,1,"span",[["class","blue"]],null,null,null,null,null)),(l()(),u.Hb(-1,null,["\u041f\u0440\u043e\u0435\u043a\u0442\u044b"])),(l()(),u.qb(10,0,null,null,20,"ion-content",[["padding",""]],null,null,null,d.db,d.m)),u.pb(11,49152,[[1,4]],0,c.t,[u.h,u.k],null,null),(l()(),u.qb(12,0,null,0,5,"ion-fab",[["edge",""],["horizontal","end"],["slot","fixed"],["vertical","top"]],null,[[null,"click"]],function(l,n,t){var u=!0;return"click"===n&&(u=!1!==l.component.createNew()&&u),u},d.gb,d.o)),u.pb(13,49152,null,0,c.v,[u.h,u.k],{horizontal:[0,"horizontal"],vertical:[1,"vertical"],edge:[2,"edge"]},null),(l()(),u.qb(14,0,null,0,3,"ion-fab-button",[],null,null,null,d.fb,d.p)),u.pb(15,49152,null,0,c.w,[u.h,u.k],null,null),(l()(),u.qb(16,0,null,0,1,"ion-icon",[["name","add"]],null,null,null,d.jb,d.s)),u.pb(17,49152,null,0,c.B,[u.h,u.k],{name:[0,"name"]},null),(l()(),u.hb(16777216,null,0,1,null,y)),u.pb(19,16384,null,0,k.j,[u.P,u.M],{ngIf:[0,"ngIf"]},null),(l()(),u.qb(20,0,null,0,0,"br",[],null,null,null,null,null)),(l()(),u.qb(21,0,null,0,3,"ion-searchbar",[["placeholder","\u041f\u043e\u0438\u0441\u043a"]],null,[[null,"ionInput"],[null,"ionBlur"],[null,"ionChange"]],function(l,n,t){var e=!0,o=l.component;return"ionBlur"===n&&(e=!1!==u.Ab(l,24)._handleBlurEvent()&&e),"ionChange"===n&&(e=!1!==u.Ab(l,24)._handleInputEvent(t.target.value)&&e),"ionInput"===n&&(e=!1!==o.search(t)&&e),e},d.wb,d.F)),u.Eb(5120,null,v.f,function(l){return[l]},[c.Lb]),u.pb(23,49152,null,0,c.ib,[u.h,u.k],{placeholder:[0,"placeholder"]},null),u.pb(24,16384,null,0,c.Lb,[u.k],null,null),(l()(),u.qb(25,0,null,0,5,"ion-grid",[],null,null,null,d.hb,d.q)),u.pb(26,49152,null,0,c.z,[u.h,u.k],null,null),(l()(),u.qb(27,0,null,0,3,"ion-row",[["justify-content-center",""]],null,null,null,d.vb,d.E)),u.pb(28,49152,null,0,c.hb,[u.h,u.k],null,null),(l()(),u.hb(16777216,null,0,1,null,m)),u.pb(30,278528,null,0,k.i,[u.P,u.M,u.t],{ngForOf:[0,"ngForOf"]},null)],function(l,n){var t=n.component;l(n,13,0,"end","top",""),l(n,17,0,"add"),l(n,19,0,t.projectService.isLoad&&t.tagService.isLoad&&t.sprintService.isLoad),l(n,23,0,"\u041f\u043e\u0438\u0441\u043a"),l(n,30,0,t.projectService.projectsList)},null)}function S(l){return u.Jb(0,[(l()(),u.qb(0,0,null,null,1,"app-projects",[],null,null,null,q,g)),u.pb(1,114688,null,0,p,[o.a,b.a,i.a,c.Mb,a.a,r.a,f.n],null,null)],function(l,n){l(n,1,0)},null)}var A=u.mb("app-projects",p,S,{},{},[]);t.d(n,"ProjectsPageModuleNgFactory",function(){return w});var w=u.nb(s,[],function(l){return u.xb([u.yb(512,u.j,u.cb,[[8,[h.a,A]],[3,u.j],u.y]),u.yb(4608,k.l,k.k,[u.v,[2,k.r]]),u.yb(4608,v.o,v.o,[]),u.yb(4608,c.b,c.b,[u.A,u.g]),u.yb(4608,c.Fb,c.Fb,[c.b,u.j,u.r,k.c]),u.yb(4608,c.Ib,c.Ib,[c.b,u.j,u.r,k.c]),u.yb(1073742336,k.b,k.b,[]),u.yb(1073742336,v.m,v.m,[]),u.yb(1073742336,v.d,v.d,[]),u.yb(1073742336,c.Cb,c.Cb,[]),u.yb(1073742336,f.p,f.p,[[2,f.v],[2,f.n]]),u.yb(1073742336,s,s,[]),u.yb(1024,f.l,function(){return[[{path:"",component:p}]]},[])])})}}]);