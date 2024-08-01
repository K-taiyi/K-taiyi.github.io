import { createRouter, createWebHistory } from "vue-router";
import adminRouter from "../router/adminRouter";
import homeView from "../views/homeView.vue";
import aboutView from "../views/aboutView.vue";
import shopView from "../views/shopView.vue";
import accessoView from "../views/accessoView.vue";
import contactView from "../views/contactView.vue";
import signInView from "@/views/signInView.vue";
import electView from "../views/electView.vue";
import adminView from "../views/adminView.vue";
import SignUpView from "../views/signUpView.vue";
import addNew from "@/views/admin/addNew.vue";
import adminLogin from "../views/admin/adminLogin.vue";
import uploadfile from "@/views/admin/uploadfile.vue";
const routes = [
  {
    path: "",
    name: "homePage",
    component: homeView,
  },
  {
    path: "/about",
    name: "aboutPage",
    component: aboutView,
  },
  {
    path: "/shop/:cat_id",
    name: "shopPage",
    component: shopView,
  },
  {
    path: "/accessories/:cat_id",
    name: "accessoPage",
    component: accessoView,
  },
  {
    path: "/contact",
    name: "contactPage",
    component: contactView,
  },
  {
    path: "/signUp",
    name: "signupPage",
    component: SignUpView,
  },
  {
    path: "/signIn",
    name: "signInPage",
    component: signInView,
  },
  {
    path: "/scooter/:cat_id",
    name: "scooterPage",
    component: electView,
  },
  {
    path: "/admin",
    name: "adminPage",
    component: adminView,
  },
  {
    path: "/adminLogin",
    name: "adminLogin",
    component: adminLogin,
  },
  {
    path: "/newProduct",
    name: "AddNewProduct",
    component: addNew,
  },
  {
    path: "/upload",
    name: "uploadFile",
    component: uploadfile,
  },
];

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  // routes: [...routes, adminRouter.options.routes],
  routes: routes.concat(adminRouter.options.routes), // \^ the same meaning
});

export default router;
