//ko.validation.configure({
//    insertMessages: true,
//    decorateElement: true,
//    errorElementClass: 'error'
//});

function Contact(data) {
    var self = this;
    self.subject = ko.observable(data.Subject);
    self.sendFrom = ko.observable(data.SendFrom);
    self.name = ko.observable(data.Name);
    self.company = ko.observable(data.Company);
    self.email = ko.observable(data.Email);
    self.phone = ko.observable(data.Phone);
    self.message = ko.observable(data.Message);
    self.gdpr = ko.observable(data.Gdpr);
}

function ContactViewModel(data) {

    var self = this;
    self.contact = ko.observable(new Contact(''));
    self.successView = ko.observable(false);
    self.errorView = ko.observable(false);

    self.validationErrors = ko.validation.group([self.contact], { deep: true, observable: false });

    self.submit = function (data) {
  
        if (self.validationErrors().length > 0) {
            self.validationErrors.showAllMessages();
            $('.error:first input').focus();

            return;
        }

        $.ajax({
            method: 'post',
            data: self.contact(),
            url: '/umbraco/api/subscribe/saveSubscribe',
            success: function (data) {
                self.contact(null);
            },
            error: function (errormessage) {
                self.errorView(true);
            }
        });
    }
}
var ContactPage = new ContactViewModel();
ko.applyBindings(ContactPage);