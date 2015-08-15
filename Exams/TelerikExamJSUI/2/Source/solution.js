function solve() {

    $.fn.datepickera = function () {
        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];

        Date.prototype.getMonthName = function () {
            return MONTH_NAMES[this.getMonth()];
        };

        Date.prototype.getDayName = function () {
            return WEEK_DAY_NAMES[this.getDay()];
        };
		
		// you are welcome :)
		var date = new Date();

        var $this = $(this);

        $this.wrap('<div class="datepicker-wrapper"></div>');

        var $content = $('<div />').addClass('datepicker-content').innerText = '1';
        var $content1 = $('<div />').addClass('datepicker-content').innerText = '1';
        var $content2 = $('<div />').addClass('datepicker-content').innerText = '1';
        var $content3 = $('<div />').addClass('datepicker-content').innerText = '1';

        $content.appendTo($this);
        $content1.appendTo($this);
        $content2.appendTo($this);
        $content3.appendTo($this);



		console.log(date.getDayName());
		console.log(date.getMonthName());

        return this;
    };
};