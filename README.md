# Estudos de bibliotecas no C#

Neste repositório registrarei o meu progresso no curso "C#: criando e distribuindo bibliotecas em .NET", curso este onde irei aprender a utilizar bibliotecas externas, criar minhas próprias bibliotecas e distribuí-las utilizando o NuGet, além de entender como funcionam os arquivos ".dll" das bibliotecas e etc.

Todas as anotações que faço enquanto vejo as aulas podem ser encontradas no arquivo "anotacoes.txt" na raiz do repositório.

## C#: criando e distribuindo bibliotecas em .NET

### Aula 1

#### Criando biblioteca e utilizando o NuGet

Nesta aula aprendi um pouco mais sobre como funcionam os projetos C# e os arquivos ".csproj", que são parecidos com os arquivos "pom.xml" do Maven.

Aprendi a adicionar referências à bibliotecas que possuimos na nossa máquina, assim como adicionar bibliotecas externas utilizando o NuGet pelo próprio VisualStudio, sem a necessidade de baixar a biblioteca manualmente.

### Aula 2

#### Entendendo visibilidade em bibliotecas

Nesta aula pude entender realmente a utilidade do modificador de visibilidade "internal", que faz com que uma classe ou membro estejam disponíveis apenas na biblioteca ou assembly onde foram declarados.

Além disso, aprendi sobre o modificador "protected internal", que faz com que um membro internal de uma classe possa ser acessado por outras classes em sua hierarquia, mesmo que elas estejam fora do assembly onde a classe superior foi declarada.
