import axios from 'axios'

const pessoas = []

const pessoasFunc = {
    async adicionar(state,user){
       axios.post('https://localhost:5001/v1/pessoas/', {
          name: user.nome,
          email: user.email,
          cor: user.cor,
        })
        .then(res => console.log(res))
        .catch(e => {
          console.log(e)
        })
        alert('Adicionado com sucesso')
      }
}

export { pessoas, pessoasFunc }