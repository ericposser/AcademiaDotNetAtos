//ex 1
// function minhafuncao1(){
//     var btn = document.getElementById("bvermelho");
    
//     document.body.style.backgroundColor = 'red';
// }

// function minhafuncao2(){
//     var btn = document.getElementById("bverde");
    
//     document.body.style.backgroundColor = 'green';
// }

// function minhafuncao3(){
//     var btn = document.getElementById("bazul");
    
//     document.body.style.backgroundColor = 'blue';
// }

// function minhafuncao4(){
//     var btn = document.getElementById("bamarelo");
    
//     document.body.style.backgroundColor = 'yellow';
// }


//ex 2
// function minhafuncao1(){
//     document.body.style.backgroundColor = 'red';
//  }

//  function minhafuncao2(){
//     document.body.style.backgroundColor = 'blue';
//  }

//  function minhafuncao3(){
//     document.body.style.backgroundColor = 'green';
//  }

//  function minhafuncao4(){
//     document.body.style.backgroundColor = 'yellow';
//  }

//ex 3
// function minhafuncao1(){
//     document.body.style.backgroundColor = 'green';
//  }

//  function minhafuncao2(){
//     document.body.style.backgroundColor = 'yellow';
//  }

//  function minhafuncao3(){
//     document.body.style.backgroundColor = 'blue';
//  }

//  function minhafuncao4(){
//     document.body.style.backgroundColor = 'red';
//  }

//ex 4
// function ocultarText(el){
//     var display = document.getElementById(el).style.display;
//     var botao = document.getElementById("bt");

//     if(display == "none"){
//         document.getElementById(el).style.display = 'block';
//         botao.innerHTML = "Esconder";
//     }
//     else{
//         document.getElementById(el).style.display = 'none';
//         botao.innerHTML = "Mostrar";
//     }
// }

//ex 5
// function checar(){
//     var box = document.getElementsByName("complementos");
//     var bt = document.getElementById("aplica");
    
//     var cont = 0;

//     for(i=0; i< box.length; i++){
//         if(box[i].checked == true){
//             cont++;
//         }     
//            }
//     if(cont >= 2){
//         document.getElementById("aplica").removeAttribute("disabled");
//     }
//     else {
//         document.getElementById("aplica").setAttribute("disabled", "disabled");
//     }
// }

//ex 6, 7, 8
// function letraBranca(){
//     var paragrafo = document.getElementById("p1");
//     paragrafo.style.color = "white";
// }

// function letraPreta(){
//     var paragrafo = document.getElementById("p1");
//     paragrafo.style.color = "black";
// }
// function fundoPreto(){
//     var paragrafo = document.getElementById("p1");
//     paragrafo.style.backgroundColor = "black";
// }
// function fundoBranco(){
//     var paragrafo = document.getElementById("p1");
//     paragrafo.style.backgroundColor = "white";
// }
// function fonteMaior(){
//     var paragrafo = document.getElementById("p1");
//     paragrafo.style.fontSize = "20px";
// }

// function fonteMenor(){
//     var paragrafo = document.getElementById("p1");
//     paragrafo.style.fontSize = "15px";
// }

// function fonteMaiuscula(){
//     var paragrafo = document.getElementById("p1");
//     paragrafo.style.textTransform = "uppercase";
// }

// function fonteMinuscula(){
//     var paragrafo = document.getElementById("p1");
//     paragrafo.style.textTransform = "lowercase";
// }

//ex 9 
// function submit(){
//     //colocando os valores dos inputs dentro de variaveis
//     var usuario = document.getElementById("login").value;
//     var senha = document.getElementById("password").value;
//     var conf_senha = document.getElementById("confirm_senha").value;

//         // if para se os nao estiver nada dentro das variaveis/campos emitir a uma mensagem para preencher os campos
//         if(usuario == "" || senha == "" || conf_senha == ""){
//             alert("Preencha todos os campos!");
//         }

//         //caso os campos senha e confirmar senha forem diferentes, emite a mensagem "senhas nao coonferem"
//         else if(senha != conf_senha){
//             alert("As senha nao conferem!");
//         }
    
//         else if(senha < 6 || senha > 10){
//             alert("A senha deve possuir entre 6 e 10 caracteres");
//         }
        
//         //caso tudo esteja certo emite a mensagem "Cadastro Concluido"
//         else{
//             alert("Cadastro Concluido");
//         }
    
// }

//ex 10
// function check(){

//     //habilitando os campos "cpf" e "data de nascimento caso o checkbox "pessoa fisica" for selecionado
//     if(document.getElementById("fisica").checked){
//         document.getElementById("cpf").removeAttribute("disabled");
//         document.getElementById("nasc").removeAttribute("disabled");
//     }

//     //desabilitando os campos "cpf" e "data de nascimento" caso o checkbox "pessoa fisica" nao for selecionado
//     else {
//         document.getElementById("cpf").setAttribute("disabled", "disabled");
//         document.getElementById("nasc").setAttribute("disabled", "disabled");
//     }


//     //habilitando o campo "cnpj" caso o checkbox "pessoa juridica" for selecionado
//     if(document.getElementById("juridica").checked){
//         document.getElementById("cnpj").removeAttribute("disabled");
//     }
//     //desabilitando o campo "cnpj" caso o checkbox "pessoa juridica" nao for selecionado
//     else {
//         document.getElementById("cnpj").setAttribute("disabled", "disabled");
//     }
// }
//     //função para mostrar a mensagem "cadastro concluido" ao apertar o botao
// function submit(){
//     alert("cadastro Concluido!!");
// }

