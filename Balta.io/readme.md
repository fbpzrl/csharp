# Conceitos de C#

&nbsp;

## Namespace

- Namespaces são divisões lógicas
- Não pode haver duas classes com o mesmo nome no mesmo Namespace
- Normalmente o nome do Namespace é o nome da pasta onde o arquivo está
- O escopo de um Namespace é definido entre as chaves
- O ideal é ter apenas um namespace e uma classe por arquivo
- O Namespace pode ser reutilizado (estar presente em diversos arquivos)
- O nome do Namespace deve começar com letra maiúscula e deve-se evitar usar caracteres especiais como traços, acentos e outros
- Durante a execução todos os arquivos do C# são unificados, ou seja, todos os arquivos ficam em uma única DLL. As pastas são ignoradas, sendo considerada somente a divisão lógica (Namespaces).
  &nbsp;

## Using

- Importações definem as bibliotecas (internas ou externas) que nossa aplicação irá utilizar
- O using é usado no começo do programa (boa prática)
- Serve para organizar o código em pastas e namespaces (principalmente em grandes projetos)
  &nbsp;

## Variáveis

- É algo utilizado para armazenar informações que podem mudar
- É possível informar um valor já na criação da variável. Se não for informado, o valor padrão será aplicado
- Informar primeiro o Tipo da Variável antes do nome
- O tipo var é um tipo genérico onde cabe qualquer valor. Diferente dos tipos primitivos, o tipo var precisa ser inicializado com algum valor
- Não começar com números
- A primeira letra é SEMPRE minúscula. Quando for um nome composto, usar padrão camelCase
  &nbsp;

## Constantes

- É algo utilizado para armazenar informações que não podem mudar
- Usa a palavra reservada const
- Define-se a constante e em seguida o tipo
- Precisa ser inicializada com algum valor
- São mais otimizadas que as variáveis
- Recomendado usar frequentemente
- Nomes de constantes são com todas as letras maiúsculas, separadas por "\_" (Convenção)
  &nbsp;

## Comentários

```
// Comentário em uma linha

/*
  Comentário em várias
  linhas
*/

/// Notação XML (Metadata)
```

&nbsp;

## Tipos Primitivos

- Também conhecidos como <strong>built-in types</strong>
- São chamados de Tipos de Valor (armazenam o valor, e não uma referência para um item na memória)
- São classificados em:
 - Tipos Simples (Simple Types)
 - Enumeradores (Enums)
 - Estruturas (Structs)
 - Tipos Nulos (Nullable Types)
- Cada tipo possui uma capacidade
