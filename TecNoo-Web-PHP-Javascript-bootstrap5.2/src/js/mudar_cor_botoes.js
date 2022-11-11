//Muda a cor da div plano prata
function mudacorPrata(){
  let btn = document.getElementById("prata")

  btn.classList.remove("bg-light");
  btn.classList.add("bg-secondary");
}
//Volta a cor de fundo da div plano prata
function voltaOriginalPrata(){
  let btn1 = document.getElementById("prata")

  btn1.classList.remove("bg-secondary");
  btn1.classList.add("bg-light");
}

//Muda a cor da div plano ouro
function mudacorOuro(){
    let btn = document.getElementById("ouro")
  
    btn.classList.remove("bg-light");
    btn.classList.add("bg-warning");
  }
  //Volta a cor de fundo da div plano ouro
  function voltaOriginalOuro(){
    let btn = document.getElementById("ouro")
  
    btn.classList.remove("bg-warning");
    btn.classList.add("bg-light");
  }

  //Muda a cor da div plano diamante
function mudacorDiamante(){
    let btn = document.getElementById("diamante")
  
    btn.classList.remove("bg-light");
    btn.classList.add("bg-info");
  }
  //Volta a cor de fundo da div plano diamante
  function voltaOriginalDiamante(){
    let btn = document.getElementById("diamante")
  
    btn.classList.remove("bg-danger");
    btn.classList.add("bg-light");
  }