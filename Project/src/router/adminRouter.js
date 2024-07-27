import { createRouter, createWebHistory } from 'vue-router'
import adminView from '../views/adminView.vue'
import adminLogin from '../views/admin/adminLogin.vue'

const routes = [
    {
        path: '/admin/dashboard',
        name: 'adminPage',
        component: adminView,
        beforeEnter: (to, from, next) => {
            var isLogin = localStorage.getItem("isLogin");
            if(isLogin != "OK"){
                next("/admin/login")
            }else{
                next()
            }
        }
    },
    {
        path: '/admin/Login',
        name: 'adminLogin',
        component: adminLogin
    }
    
]

const adminRouter = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes 
})

export default adminRouter