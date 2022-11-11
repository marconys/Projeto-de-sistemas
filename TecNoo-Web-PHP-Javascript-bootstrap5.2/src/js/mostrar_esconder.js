function mostrarCampos() { 
    
    let divOculta = document.querySelector('.esconder');

    divOculta.classList.remove('esconder');
    divOculta.classList.add('mostrar');
    

};

function esconderCampos() { 
    
    let divOculta = document.querySelector('.mostrar');

    divOculta.classList.remove('mostrar');
    divOculta.classList.add('esconder');
    
    

};

/*
function mostrarCampos() { 
    
    let divOculta = document.getElementById('oculta');

    divOculta.classList.remove('hidden');

};

function esconderCampos() { 
    
    let divOculta = document.getElementById('oculta');
    divOculta.classList.add('hidden');
    
    

};
*/