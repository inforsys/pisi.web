/// <reference path="underscore.js" />
/// <reference path="backbone.js" />

var PISI = PISI || (function () {
    var periodName,
        periodId,
        payslipViewContainer,
        payroll,
        payrollView;

    var Payroll = Backbone.Model.extend({ urlRoot: '/Api/Payroll' });
    var PayrollView = Backbone.View.extend({
        events: {
            'click a#display-tunjangan': 'showTunjangan',
            'click a#display-potongan': 'showPotongan'
        },
        template: _.template("<div><div><b>PT. Inforsys Indonesia</b></div>\
                                <span>SLIP GAJI <%= periodName%></span><hr/>\
                                <ul><li>Gaji Pokok: <%= Base %></li>\
                                    <li>Overtime: <%= OT %></li>\
                                    <li>\
                                        <a href='#' id='display-tunjangan'>\
                                            <span>Total Tunjangan:<%= Allow %></span>\
                                        </a>\
                                        <i class='icon-play tunjangan'></i>\
                                        <div id='tunjangan-view'></div>\
                                    </li>\
                                    <li>\
                                        <a href='#' id='display-potongan'>\
                                            <span>Total Potongan:<%= Dedu %></span>\
                                        </a>\
                                        <i class='icon-play potongan'></i>\
                                        <div id='potongan-view'></div>\
                                    </li>\
                                    <li>Pajak: <%= TaxPaid %></li>\
                                </ul>\
                                <hr/>\
                                <span>Take Home Pay: <%= Total %></span>\
                              </div>"),
        render: function () {
            this.$el.html(this.template(this.model));
        },
        showTunjangan: function (e) {
            if ($('i.tunjangan', this.el).hasClass('icon-eject')) {
                $('div#tunjangan-view', this.el).hide();
                $('i.tunjangan', this.el).removeClass('icon-eject');
                $('i.tunjangan', this.el).addClass('icon-play');
                return;
            }
            var allowanceList = new AllowanceList();
            var view = new AllowanceListView({ collection: allowanceList });
            $('div#tunjangan-view', this.el).html(view.render().el);
            $('div#tunjangan-view', this.el).show();
            allowanceList.fetch({ data: {
                periodId: periodId
            }
            });
            $('i.icon-play.tunjangan', this.el).removeClass('icon-play');
            $('i.tunjangan', this.el).addClass('icon-eject');
        },
        showPotongan: function (e) {
            if ($('i.potongan', this.el).hasClass('icon-eject')) {
                $('div#potongan-view', this.el).hide();
                $('i.potongan', this.el).removeClass('icon-eject');
                $('i.potongan', this.el).addClass('icon-play');
                return;
            }
            var deductionList = new DeductionList();
            var view = new DeductionListView({ collection: deductionList });
            $('div#potongan-view', this.el).html(view.render().el);
            $('div#potongan-view', this.el).show();
            deductionList.fetch({ data: {
                periodId: periodId
            }
            });
            $('i.icon-play.potongan', this.el).removeClass('icon-play');
            $('i.potongan', this.el).addClass('icon-eject');
        }
    });

    var AllowanceList = Backbone.Collection.extend({
        model: Backbone.Model.extend(),
        url: '/PayrollReport/Allowance'
    });
    var AllowanceView = Backbone.View.extend({
        tagName: 'tr',
        template: _.template('<td><%= AllowanceName %></td><td><%= Normal %></td>'),
        render: function () {
            this.$el.html(this.template(this.model.toJSON()));
            return this;
        }
    });
    var AllowanceListView = Backbone.View.extend({
        initialize: function () {
            this.collection.on('reset', function () {
                this.render();
            }, this);
        },
        tagName: 'table',
        render: function () {
            this.$el.empty();
            this.collection.forEach(function (m) {
                this.$el.append(new AllowanceView({ model: m }).render().el);
            }, this);
            return this;
        }
    });

    var DeductionList = Backbone.Collection.extend({
        model: Backbone.Model.extend(),
        url: '/PayrollReport/Deduction'
    });
    var DeductionView = Backbone.View.extend({
        tagName: 'tr',
        template: _.template('<td><%= DeductionName %></td><td><%= Normal %></td>'),
        render: function () {
            this.$el.html(this.template(this.model.toJSON()));
            return this;
        }
    });
    var DeductionListView = Backbone.View.extend({
        initialize: function () {
            this.collection.on('reset', function () {
                this.render();
            }, this);
        },
        tagName: 'table',
        render: function () {
            this.$el.empty();
            this.collection.forEach(function (m) {
                this.$el.append(new DeductionView({ model: m }).render().el);
            }, this);
            return this;
        }
    });

    function loadPayslip(period) {
        payroll = payroll || new Payroll({ id: period });
        payroll.fetch({
            success: function (model) {
                payroll.set(model.toJSON());
                payroll.set('periodName', periodName);
                console.log(payroll.toJSON());
                renderPayslip();
            }
        });
    };

    function renderPayslip() {
        payrollView = new PayrollView({ model: payroll.toJSON() });
        payrollView.render();
        $(payslipViewContainer).html(payrollView.el);
    }

    function showPayslip(e, el) {
        periodName = $(e.target).text();
        periodId = $(e.target).attr('id');
        payslipViewContainer = el;

        $("li.payslip-period-item").removeClass("active");
        $(e.target).parent().addClass("active");
        $(".payslip-view").empty();

        loadPayslip(periodId);
    }

    return {
        showPayslip: showPayslip
    };
})();

$(function() {
    $('li.payslip-period-item').click(function(e){
        PISI.showPayslip(e, '#payslip-view');    
    });
});