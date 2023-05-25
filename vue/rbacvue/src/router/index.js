import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  {
    path: '/LongIn',
    name: 'LongIn',
    component: () => import(/* webpackChunkName: "about" */ '../views/LongIn.vue')
  },
  {
    path: '/',
    name: 'Home',
    component: () => import(/* webpackChunkName: "about" */ '../views/Home.vue'),
    children:[
      {
        path: '/Admin',
        name: 'Admin',
        component: () => import("../views/Admin/List.vue")
      }
      // ,
      // {
      //   path: '/Menu',
      //   name: 'Menu',
      //   component: () => import("../views/Menu/List.vue")
      // }
    ]
  }
]

const router = new VueRouter({
  routes
})

export default router
