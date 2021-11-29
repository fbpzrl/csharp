# Conceitos de C#

## Namespace
- Namespaces são divisões lógicas
- Não pode haver duas classes com o mesmo nome no mesmo Namespace
- Normalmente o nome do Namespace é o nome da pasta onde o arquivo está
- O escopo de um Namespace é definido entre as chaves
- O ideal é ter apenas um namespace e uma classe por arquivo
- O Namespace pode ser reutilizado (estar presente em diversos arquivos)
- O nome do Namespace deve começar com letra maiúscula e deve-se evitar usar caracteres especiais como traços, acentos e outros
- Durante a execução todos os arquivos do C# são unificados, ou seja, todos os arquivos ficam em uma única DLL. As pastas são ignoradas, sendo considerada somente a divisão lógica (Namespaces).

## Using
- Importações definem as bibliotecas (internas ou externas) que nossa aplicação irá utilizar
- O using é usado no começo do programa (boa prática)
- Serve para organizar o código em pastas e namespaces (principalmente em grandes projetos)
