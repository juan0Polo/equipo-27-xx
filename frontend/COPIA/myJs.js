function funcionjs(){
    let i=10;
    var j=20;
    var r = i + j;
    console.log(r);
   alert("I + J = " + r);
   var edad = Number(prompt("Ingrese edad:"));
   alert ("edad leida = " + edad);
   let mensaje = "NO APTO PARA VOTAR";
   if(edad >= 18){
     mensaje = "APTO PARA VOTAR";         
   }
   alert(mensaje);
}