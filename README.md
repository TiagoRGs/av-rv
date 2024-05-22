# Upload de Arquivo para Firebase com Tailwind CSS

Este projeto oferece uma página web simples para upload de arquivos no Firebase Storage, utilizando Tailwind CSS para a estilização.

## Requisitos

Para configurar e usar este projeto, você precisa ter os seguintes itens instalados no seu sistema:

- Um navegador web (como Chrome, Firefox)
- Uma conexão com a internet

## Configuração

1. Clone o repositório ou baixe os arquivos do projeto.
2. Abra o arquivo `index.html` em um editor de código de sua escolha.
3. Adicione as configurações do seu Firebase na seção `<script>` no final do arquivo `index.html`. Substitua os valores de exemplo pelas configurações do seu projeto Firebase:

```html
<script>
  // Configuração do Firebase do seu aplicativo web
  const firebaseConfig = {
    apiKey: "SUA_API_KEY",
    authDomain: "SEU_AUTH_DOMAIN",
    projectId: "SEU_PROJECT_ID",
    storageBucket: "SEU_STORAGE_BUCKET",
    messagingSenderId: "SEU_MESSAGING_SENDER_ID",
    appId: "SEU_APP_ID"
  };

  // Inicializar Firebase
  firebase.initializeApp(firebaseConfig);
  const storage = firebase.storage();
</script>
```

## Uso

1. Abra o arquivo `index.html` em um navegador web.
2. Selecione um arquivo para upload clicando no botão "Escolher arquivo".
3. Clique no botão "Upload" para enviar o arquivo selecionado para o Firebase Storage.
4. Após a conclusão do upload, a URL do arquivo enviado será exibida.

## Utilizando a URL do Arquivo no Unity

Após realizar o upload do arquivo para o Firebase, você receberá uma URL pública que pode ser usada para acessar o arquivo. Note que o arquivo sempre terá o nome `video.mp4`, então a URL gerada será a mesma para todos os uploads.

## Dependências

Este projeto utiliza as seguintes dependências:

- **Tailwind CSS**: Um framework CSS utilitário.
- **Firebase**: Uma plataforma desenvolvida pelo Google para a criação de aplicativos móveis e web.

## Conclusão

Depois que o upload é concluído, a URL do arquivo enviado será exibida. Como o arquivo sempre terá o nome `video.mp4`, a URL gerada será a mesma para todos os uploads.
