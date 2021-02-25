import Vue from 'vue'
import Vuex from 'vuex'
import {pessoas, pessoasFunc} from './pessoas'

Vue.use(Vuex)

const store = new Vuex.Store({
    state: {
      items: pessoas
    },
    mutations: {
      ...pessoasFunc
    }
  })

  export default store