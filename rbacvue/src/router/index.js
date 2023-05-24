import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Longin',
    component: () => import(/* webpackChunkName: "about" */ '../views/Longin.vue')
  }
]

const router = new VueRouter({
  routes
})

export default router
