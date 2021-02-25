import Vue from 'vue'
import Cadastro from './views/Cadastro'
import Lista from './views/Lista'
import Router from 'vue-router'

Vue.use(Router)

const router = new Router ({
  mode: 'history',
  routes: [
    {
      path: '/',
      redirect: '/cadastro'
    },
    {
      path: '/cadastro',
      name: 'cadastro',
      component: Cadastro
    },
    {
      path: '/lista',
      name: 'lista',
      component: Lista
    }
  ]
})

export default router