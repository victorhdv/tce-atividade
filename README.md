# tce-atividade
Atividade prática desenvolvida utilizando dotnet e angular

###Atividade prática TCE

01 – (Valor 4,00) Construa uma API que responda no caminho /dividir/executar, rodando
localmente, que receba dois números via GET. O nome do parâmetro do primeiro número será
dividendo e o do segundo será divisor e retorno um JSON no formato abaixo. A API deverá ser
testada no navegador utilizando a seguinte URL: HTTP://localhost/dividir/executar?
Dividendo=4&divisor=2 (O servidor pode subir em uma porta diferente da porta 80, sem
problema) (valor: 3,00).

Deve ser tratada a divisão por zero. Quando o divisor for 0 (zero) o valor do resultado deverá
ser 0 (zero) e o valor do erro deve ser uma string informando da impossibilidade de se dividir
por zero, nos demais casos, o valor do resultado deverá ser o valor da divisão e o valor do erro
uma string em branco (valor: 1,00).

Formato do JSON de Resposta:

{ “resultado”: 0, “erro”: “” }

02 – (Valor 6,00) Construa uma aplicação utilizando o framework Angular que irá consumir a
API que você criou no exercício 01.

Deverá ser criada uma página HTML com no mínimo dois campos para a entrada de valores,
um para o valor do dividendo e outro para o valor do divisor e um botão para consumir a api
criada no exercício 01. Deverá ter um label para cada um dos dois campos campo (valor 1,00).

Deverá ser criada uma página HTML com um campo para informar o resultado da divisão ou a
mensagem de erro quando o divisor for iguala zero e um botão para fazer uma nova consulta
(direcionar para a página anterior) (valor 1,00).

Deverá ser criado uma validação para essa página para impedir que seja realizada a consulta
na API quando o divisor for zero (valor 1,00).

Deverá ser aplicado um CSS nas páginas para (valor 1,00):

Os labels sejam de fonte “Times New Roman” e tamanho 14 e negrito.
As caixas de texto sejam de fonte “Arial” e tamanho 12 e sem negrito.
O botão seja de fonte “Times New Roman” e tamanho 16 e negrito.

A página criada deverá realizar consultas na API e apresentar o resultado na segunda página.
Quando houver erro, o campo deve apresentar a string do erro, quando não houver erro, o
campo deve apresentar o resultado da divisão (valor 2,00).
