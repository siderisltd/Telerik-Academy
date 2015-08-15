function solve() {
    return function (selector) {
        var template = '<div class="event-calendar">' +
          '<h2 class="header">Appointments for <span class="month">{{month}}</span> <span class="year">{{year}}</span></h2>' +
          '{{#each days}}' +
          '<div class="col-date">' +
          '<div class="date">{{day}}</div>' +
          '<div class="events">' +
          '{{#each events}}' +
          '<div class="event {{importance}}" {{#if title}}title="duration: {{duration}}"{{/if}} >' +
          '{{#if title}}' +
          '<div class="title">{{title}}</div>' +
          '<span class="time">at: {{time}}</span> ' +
          '</div>' +
          '{{/if}}' +
          '{{#unless title}}' +
          '<div class="title">Free slot</div>' +
          '</div>' +
          '{{/unless}}' +
          '{{/each}}' +
          '</div>' +
          '{{/each}}' +
          '</div>';

          document.getElementById(selector).innerHTML = template;
 };
}

module.exports = solve;