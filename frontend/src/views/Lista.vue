<template>
<div id="home">
     <b-table striped hover :items="$store.state.items" :fields="fields"></b-table>
</div>
</template>

<script>
  import axios from 'axios'
  export default {
    name: 'lista',
    data() {
      return {
        // Note 'isActive' is left out and will not appear in the rendered table
        fields: [
              {
                key: 'name',
                sortable: true
              },
              {
                key: 'email',
                sortable: true
              },
          {
            key: 'cor',
            sortable: true,
            // Variant applies to the whole column, including the header and footer
            variant: 'danger'
          }
        ],        
      }
    },
    methods: {        
        carregarItens: function(){
            axios.get("https://localhost:5001/v1/pessoas/")
            .then(res => {
              this.$store.state.items = res.data
            })
        }
    },
    created: function(){
      this.carregarItens();
    }
  }
</script>

<style>

</style>