
   function saludar(){
       var  mensaje = "saludando la clase";
       alert(mensaje);
       let n1 = 10;
       var n2 = 20;
       var r = n1 + n2;
       alert(r);
       let edad = prompt("EDAD: ");
       if (Number(edad) >= 18) mensaje = "puede votar";
       else mensaje = "no puede votar";
       console.log(n1);
       console.log(n2);
       console.log(r);
       var nombre = prompt("INGRESE SU NOMBRE: ");
       console.log(nombre);
       console.log(mensaje);
   }