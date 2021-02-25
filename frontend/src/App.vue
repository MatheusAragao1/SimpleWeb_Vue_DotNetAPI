<template>
  <div id="app">    
  <b-navbar toggleable="lg" type="dark" variant="info">
    <b-navbar-brand href="#">Site treino Vue/Dotnet API</b-navbar-brand>

    <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

    <b-collapse id="nav-collapse" is-nav>
      <b-navbar-nav >
        <b-nav-item to="/cadastro">Cadastro</b-nav-item>
        <b-nav-item to="/lista">Listar</b-nav-item>
      </b-navbar-nav>
  
    </b-collapse>
  </b-navbar>


    <router-view />
  </div>
</template>

<script>

export default {
  name: 'App',
}
</script>

<style>

</style>
