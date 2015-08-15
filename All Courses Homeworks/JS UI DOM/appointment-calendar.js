var Calendar = (function (date) {
    var currentDate = date || new Date();

    function getCurrentMonthAsString(monthIndex) {
        var month =["January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December"
];
        return month[monthIndex]
    }

    function getCurrentDayAsString(dayIndex){
        var days = [
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        ];

        return days[dayIndex]
    }

    function getTotalMonthDays(year, month){
        return new Date(year, month, 0).getDate();
    }

    function getFirstDayOfMonth(year, month){
        var firstDayDate = new Date(year, month, 1);
        var firstDayAsString = getCurrentDayAsString(firstDayDate.getDay());

        return {
            weekPositionIndex: firstDayDate.getDay(),
            asString: firstDayAsString
        }
    }

    function getLastDayOfMonth(year, month){
        var lastDayDate = new Date(year, month + 1, 0);
        var lastDayAsString = getCurrentDayAsString(lastDayDate.getDay());

        return {
            weekPositionIndex: lastDayDate.getDay(),
            asString: lastDayAsString
        }
    }

    var Calendar = {
        init: function(date){
            if(date){
                var newDate = new Date(date);
                currentDate = newDate;
            }


            this.currentYear = currentDate.getFullYear();
            this.currentMonthIndex = currentDate.getMonth();  // zero based indexer
            this.dayPositionInMonth = currentDate.getUTCDate();

            if(typeof date === 'undefined'){
            this.currentDayWeekPositionIndex = currentDate.getDay(); // 0 based sunday not monday
            this.currentHour = currentDate.getHours();
            this.currentMinute = currentDate.getMinutes();
            }

            this.firstDayOfCurrentMonth = getFirstDayOfMonth(this.currentYear, this.currentMonthIndex);
            this.lastDayOfCurrentMonth = getLastDayOfMonth(this.currentYear, this.currentMonthIndex);

            this.currentMonthAsString = getCurrentMonthAsString(this.currentMonthIndex);
            this.currentDayAsString = getCurrentDayAsString(this.currentDayWeekPositionIndex);
            this.numberOfDaysInThisMonth = getTotalMonthDays(this.currentYear, this.currentMonthIndex + 1);
            this.numberOfDaysInPreviousMonth = getTotalMonthDays(this.currentYear, this.currentMonthIndex);
            return this;
        }
    };


     return Calendar;
}());

function renderCalendar(calendar){
    if(!Calendar.isPrototypeOf(calendar)){
        throw new Error('The parameter must be instance of Calendar');
    }

    //Creates UL Element with calendar-ul-list ID

        var ulNode = document.createElement('DIV');
        document.getElementById('calendar')
            .appendChild(ulNode)
            .setAttribute('id', 'calendar-ul-list');


    var _numbersOfDaysInOneWeek = 6,
        i = 0,
        currentDayIndex = 0;
    var  differenceBetweenMondayAndStartDate = _numbersOfDaysInOneWeek - ((_numbersOfDaysInOneWeek ) - calendar.firstDayOfCurrentMonth.weekPositionIndex);


    //za specifichni meseci naprimer noemvri 2015

    if(differenceBetweenCurrentDayOfWeekAndSunday === 6){
        differenceBetweenCurrentDayOfWeekAndSunday = 0;
    }

    var days = [
        "sunday",
        "monday",
        "tuesday",
        "wednesday",
        "thursday",
        "friday",
        "saturday"
    ];

    //inserting days as table captions

    for (var l = 0; l < days.length; l++) {
        var currentDay = days[l];

        var dayNode = document.createElement('LI'),
            textNode = document.createTextNode(currentDay);

        dayNode.appendChild(textNode);

        document.getElementById('calendar-ul-list')
            .appendChild(dayNode)
            .setAttribute('class', 'week-day-names ' + currentDay);


    }

    //creadting single table row   - separator

    var ulNode = document.createElement('BUTTON');
    document.getElementById('calendar-ul-list')
        .appendChild(ulNode)
        .setAttribute('id', 'calendar-table-row');



    while(true){
        var currentDay = days[currentDayIndex],
            currentYear = calendar.currentYear;
        //weekPosition ,monthPosition, asString


        //

        //1. namirame koi e purviq den ot meseca kato den e vajno (obekt s name i value)

        //2. vijdame razlikata mu ot ponedelnik do tekushtiq den   [razlika]
        if(differenceBetweenMondayAndStartDate > 0){

            //proverka ako sme 1 mesec sledvashtata godina da slojim currentYear - 1 i sled metoda da si q fixnem

            if(calendar.currentMonthIndex === 0){
                currentYear -= 1;
            }



            //
            for (var j = calendar.numberOfDaysInPreviousMonth - differenceBetweenMondayAndStartDate + 1;
                 j <= calendar.numberOfDaysInPreviousMonth ; j++) {

                // pulnim obekta ot nedelq ili ponedelnik da e = j

                // tova sa ot predniq mesec datite

                var previousMonthNode = document.createElement('BUTTON'),
                    textNode = document.createTextNode(j);

                previousMonthNode.appendChild(textNode);

                document.getElementById('calendar-ul-list')
                    .appendChild(previousMonthNode)
                    .setAttribute('class', 'calendar-days ' + currentDay + ' ' + (calendar.currentMonthIndex - 1) + ' ' + currentYear);


                currentDayIndex += 1;
                currentDay = days[currentDayIndex];
            }
            differenceBetweenMondayAndStartDate = 0;
            i = 1;
        }
                //tuk si vrushtam godinata obratno
        if(calendar.currentMonthIndex === 0){
            currentYear += 1;
        }

        var previousMonthNode = document.createElement('BUTTON'),
            textNode = document.createTextNode(i);

        previousMonthNode.appendChild(textNode);

        document.getElementById('calendar-ul-list')
            .appendChild(previousMonthNode)
            .setAttribute('class', 'calendar-days ' + currentDay + ' ' + calendar.currentMonthIndex + ' ' + currentYear);
        //pulnim si normalno obektite ot 1 do kraq na meseca


        // ako e po malko ot nedelq zapulvame ostatuka s sledvashtiq mesec





        if( i === calendar.numberOfDaysInThisMonth){
            var differenceBetweenCurrentDayOfWeekAndSunday = _numbersOfDaysInOneWeek - currentDayIndex;

            if(calendar.currentMonthIndex === 11){
                currentYear += 1;
            }

            //console.log(differenceBetweenCurrentDayOfWeekAndSunday);
            if(differenceBetweenCurrentDayOfWeekAndSunday > 0){

                for (var k = 1; k <= differenceBetweenCurrentDayOfWeekAndSunday; k++) {

                    currentDayIndex += 1;
                    currentDay = days[currentDayIndex];

                    // pulnim obekta ot nedelq ili ponedelnik da e = j

                    var previousMonthNode = document.createElement('BUTTON'),
                        textNode = document.createTextNode(k);

                    previousMonthNode.appendChild(textNode);

                    document.getElementById('calendar-ul-list')
                        .appendChild(previousMonthNode)
                        .setAttribute('class', 'calendar-days ' + currentDay + ' ' + (calendar.currentMonthIndex + 1 + ' ' + currentYear));





                    if(currentDayIndex === 6){
                        var ulNode = document.createElement('BUTTON');
                        document.getElementById('calendar-ul-list')
                            .appendChild(ulNode)
                            .setAttribute('id', 'calendar-table-row');
                    }

                }
            }
            break;
        }

        if(calendar.currentMonthIndex === 11){
            currentYear -= 1;
        }

        else {
            if(currentDayIndex === 6){
                var ulNode = document.createElement('BUTTON');
                document.getElementById('calendar-ul-list')
                    .appendChild(ulNode)
                    .setAttribute('id', 'calendar-table-row');
            }
        }


        i += 1;
        currentDayIndex += 1;


        if(currentDayIndex === 7){
            currentDayIndex = 0;
        }
    }

    var nextMonthButton = document.createElement('BUTTON'),
        nextMonthInnerHTML = document.createTextNode('-->');

    nextMonthButton.appendChild(nextMonthInnerHTML);

    document.getElementById('calendar-ul-list')
        .appendChild(nextMonthButton)
        .setAttribute('id', 'calendar-getNextMonth');





    //for (var day = 1; day <= calendar.numberOfDaysInThisMonth; day++) {
    //    var node = document.createElement('LI'),
    //        textNode = document.createTextNode(day);
    //
    //
    //    node.appendChild(textNode);
    //
    //    document.getElementById('calendar-ul-list').appendChild(node).setAttribute('class', 'calendar-li-days');
    //}

    dayClickHandler(calendar);
}


function dayClickHandler (calendar){
    if (document.body.addEventListener)
    {
        document.body.addEventListener('click',yourHandler,false);
    }
    else
    {
        document.body.attachEvent('onclick',yourHandler);  //for IE
    }

    function passCalendar(){
        return calendar;
    }

    function yourHandler(e)
    {
        e = e || window.event;
        var target = e.target || e.srcElement;

        //rendering nextMonth calendar
        if (target.id.match('calendar-getNextMonth'))
        {
            function clone(obj) {
                if (null == obj || "object" != typeof obj) return obj;
                var copy = obj.constructor();
                for (var attr in obj) {
                    if (obj.hasOwnProperty(attr)) copy[attr] = obj[attr];
                }
                return copy;
            }
            var currentCalendar = clone(passCalendar());

            //removing current rendered calendar
            //div s id calendar

            var calendarToRemove = document.getElementById("calendar");

            //child nodes-a na tozi kalendar 1vo
            while (calendarToRemove.hasChildNodes()) {
                calendarToRemove.removeChild(calendarToRemove.lastChild);
            }

            //child nodes-a na tozi kalendar 1

            var newYear = currentCalendar.currentYear;
            var newMonth = (currentCalendar.currentMonthIndex + 2).toString();

            if(newMonth < 10){
                newMonth = '0' + newMonth;
            }

            var newDate = (newYear + '-' + newMonth);


            var newCalendar = Object.create(Calendar).init(newDate);

            renderCalendar(newCalendar);


        }

        if (target.className.match('calendar-days'))
        {
            var element = target;
            var elementClassesAsArray = element.classList.toString().split(' ');
            var monthIndex = elementClassesAsArray.length - 2;
            var elementYear = elementClassesAsArray[monthIndex + 1];
            var elementMonth = elementClassesAsArray[monthIndex];
            var elementDay = element.innerHTML;


            console.log('month : ' + elementMonth);
            console.log('day : ' + elementDay);
            console.log('year : ' + elementYear);
        }
    }
}

function clone(obj) {
    if (null == obj || "object" != typeof obj) return obj;
    var copy = obj.constructor();
    for (var attr in obj) {
        if (obj.hasOwnProperty(attr)) copy[attr] = obj[attr];
    }
    return copy;
}

//samata data trqbva da znae ot koi mesec e za da moje kato se cukne da si znae i da raisne event
var calendar = Object.create(Calendar).init();
///"2015-03"
//var newYear = calendar.currentYear;
//var newMonth = (calendar.currentMonthIndex + 2).toString();
//
//if(newMonth < 10){
//    newMonth = '0' + newMonth;
//}
//
//var newDate = (newYear + '-' + newMonth);
//
console.log(calendar);

//renderCalendar(calendar);


//zabiva zashtoto nqma 13 ti mesec

// na ponedelnik noemvri 2015 dava 0 kato tekst !!!

// raise va event za vsichki dati kato se cukne dadena data