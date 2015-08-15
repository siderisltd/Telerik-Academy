/* globals $ */
$.fn.gallery = function (columnPerRow) {
    //setvame kolonite
    columnPerRow = columnPerRow || 4;

    // vzimame tekushtiq element i rabotim samo s nego i dulbaem
    var $this = $(this);  // konkretniq element na koito se izpulnqva
    $this.addClass('gallery');

    var $galleryList = $this.children('.gallery-list');
    var $selected = $this.children('.selected'); //tursi samo direktnite deca
    //skrivame selektiranite zashtoto po default ima nqkakvi selektirani
    $selected.hide();

    //glasim kolko na red da se pokazvat       find() tursi i v decata na decata na tozi element i vadi vsicki s
    //daden selektor
    var $imageContainers = $this.find('.image-container'); // vzimame elementa v koito sa ni vsichki snimki
        // each() e kato forEach na selektiranite jQuery elementi
    $imageContainers.each(function(index, element){
        if(index % columnPerRow === 0){
            $(element).addClass('clearfix');
        }
    });

    var $previousImage = $selected.find('#previous-image');
    var $currentImage = $selected.find('#current-image');
    var $nextImage = $selected.find('#next-image');


    var $disablingDiv = $('<div />').appendTo($this);

    //kogato nqkoi klickne na kartinka v gallery list -a  iskam da mi se izpulni tova
    $galleryList.on('click', 'img', function (){
        //sega iskame da ni vizualizira pravilnata kotka kato clicknem na neq
        //var imgSrc = $(this).attr('src'); //vzimame mu stoinostta ot attributa src
        //var imgIndex = parseInt($(this).data('info')); //tuk  vzimame stoinostta ot data info
        //tova e izneseno v funkciq
        var imageInfo = getImageInformation($(this));
        $galleryList.addClass('blurred');
        //za da disable-nem background-a nachina e da dobavim nov div koito da e s golqm z-index i da pokrie dr.
        $disablingDiv.addClass('disabled-background');

        //$currentImage.attr('src', imgSrc);
        //$currentImage.attr('data-info', imgIndex);

        setImageInformation($currentImage, imageInfo.src, imageInfo.index);


        //za previous i za next
        var previousIndex = getPreviousIndex(imageInfo.index);
        var previousImage = getImageByIndex(previousIndex);
        var previousImageInfo = getImageInformation(previousImage);
        setImageInformation(previousImage, previousImageInfo.src, previousImageInfo.index);

        var nextIndex = getNextIndex(imageInfo.index);
        var nextImage = getImageByIndex(nextIndex);
        var nextImageInfo = getImageInformation(nextImage);
        setImageInformation(nextImage, nextImageInfo.src, nextImageInfo.index);

       $selected.show();
    });

    // funkcionalnost kato se cukne na neq i da se skriva

    $currentImage.on('click', function(){
        $selected.hide();

        $disablingDiv.removeClass('disabled-background');
        $galleryList.removeClass('blurred');
    });

    function getImageByIndex(index) {
        return $this.find('img[data-info="'+ index +'"]')
    }

    function getImageInformation($element) {
        return {
            src: $element.attr('src'),
            index: parseInt($element.data('info'))
        }
    }

    function setImageInformation($element, src, index) {
        $element.attr('src', src);
        $element.attr('data-info', index);
    }

    function getNextIndex (index){
        var nextIndex = ++index;
        if (nextIndex > $imageContainers.length) {
            nextIndex = 1;
        }
        return nextIndex;
    }

    function getPreviousIndex (index) {
        var previousIndex = --index;
        if(previousIndex < 1 ){
            previousIndex = $imageContainers.length;
        }
        return previousIndex;
    }


    return this;
};