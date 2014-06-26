function createImagesPreviewer(selector, items) {
    var divContainer = document.querySelector(selector);
    var animals = items;
    var animalsCount = items.length;
    var divWithAnimal = document.createElement('div');
    var divTitle = document.createElement('h3');
    var animalImg = document.createElement('img');
    var frag = document.createDocumentFragment();



    divContainer.style.width = '560px';
    divContainer.style.height = '400px';
    divContainer.style.margin = '40px';
    divContainer.style.overflowY = 'scroll';
    divWithAnimal.style.textAlign = 'right';
    divWithAnimal.style.marginRight = '10px';



    var input = document.createElement('input');
    var label = document.createElement('p');
    label.textContent = 'Filter';
    label.style.position = 'absolute';
    label.style.top = '-10px';
    label.style.left = '500px';
    label.setAttribute('for', 'search');
    input.setAttribute('id', 'search');
    input.setAttribute('type', 'text');
    input.style.position = 'absolute';
    input.style.top = '20px';
    input.style.left = '453px';

    frag.appendChild(label);
    frag.appendChild(input);

    for (var i = 0; i < animalsCount; i += 1) {
        var currentAnimal = divWithAnimal.cloneNode('true');
        var currentAnimalTitle = divTitle.cloneNode('true');
        var currentAnimalImg = animalImg.cloneNode('true');
        currentAnimalTitle.innerText = animals[i].title;
        currentAnimalImg.setAttribute("src", animals[i].url);
        currentAnimalImg.setAttribute("width", "100");

        currentAnimal.appendChild(currentAnimalTitle);
        currentAnimal.appendChild(currentAnimalImg);
        frag.appendChild(currentAnimal);
    }

    var divWithBigImg = divWithAnimal.cloneNode('true');
    var animalTitle = divTitle.cloneNode('true');
    var animalBigImg = animalImg.cloneNode('true');
    animalTitle.innerText = animals[0].title;
    animalTitle.style.textAlign = 'center';
    animalTitle.style.fontSize = '30px';
    animalBigImg.setAttribute("src", animals[0].url);
    animalBigImg.setAttribute("width", "450");
    divWithBigImg.style.position = 'absolute';
    divWithBigImg.style.top = '0';
    divWithBigImg.style.left = '20px';

    divWithBigImg.appendChild(animalTitle);
    divWithBigImg.appendChild(animalBigImg);

    divContainer.appendChild(frag);
    divContainer.appendChild(divWithBigImg);

    divContainer.addEventListener('click', function (ev) {
        var animal = ev.target;
        animalTitle.innerText = animal.parentNode.firstChild.textContent;
        animalBigImg.setAttribute("src", animal.src);
    });

    divContainer.addEventListener('mouseover', function (ev) {
        var animal = ev.target;
        var backgr = animal.parentNode;
        backgr.style.background.color = 'gray';
    });
    divContainer.addEventListener('mouseout', function (ev) {
        var animal = ev.target;
        console.log(animal);
        var backgr = animal.parentNode;
        console.log(backgr);
        backgr.style.background.color = 'white';
    });
}