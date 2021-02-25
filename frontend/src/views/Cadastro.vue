<template>
<div id="home">
    <b-form @submit="onSubmit" @reset="onReset">

      <b-form-group id="input-group-2" label="Digite seu nome:" label-for="input-2">
        <b-form-input
          id="input-2"
          v-model="form.nome"
          placeholder="Digite nome"
          required
        ></b-form-input>
      </b-form-group>
      
      <b-form-group
        id="input-group-1"
        label="Digite seu email:"
        label-for="input-1"
      >
        <b-form-input
          id="input-1"
          v-model="form.email"
          type="email"
          placeholder="Digite email"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-3" label="Cor:" label-for="input-3">
        <b-form-select
          id="input-3"
          v-model="form.cor"
          :options="cores"
          required
        ></b-form-select>
      </b-form-group>

      <b-button type="submit" variant="primary" style="margin-right: 10px">Cadastrar</b-button>
      <b-button type="reset" variant="danger">Limpar</b-button>
    </b-form>
    <b-card class="mt-3" header="Objeto que será cadastrado">
      <pre class="m-0">{{ form }}</pre>
    </b-card>
</div>
</template>

<script>
  export default {
    name: 'cadastro',
    data() {
      return {
        form: {
          email: '',
          nome: '',
          cor: null,
        },
        cores: [{ text: 'Selecione uma', value: null }, 'Azul', 'Vermelho', 'Verde', ],
        show: true
      }
    },
    methods: {
      onSubmit(event) {
        event.preventDefault()
        this.$store.commit('adicionar', this.form)
      },
      onReset(event) {
        event.preventDefault()
        this.form.email = ''
        this.form.nome = ''
        this.form.cor = null
      }
    }
  }
</script>

<style>
    #home {
        width: 30%;
        margin: 0 auto;
        margin-top: 10px;
    }
</style>