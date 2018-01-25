var ViewModel = function () {
    var self = this;
    self.user_accounts = ko.observableArray();
    self.newUser = {
        UserType: ko.observable(),
        Email: ko.observable(),
        Password: ko.observable(),
        DateOfBirth: ko.observable(),
        Gender: ko.observable(),
        IsActive: ko.observable(),
        ContactNumber: ko.observable(),
        SmsNotificationActive: ko.observable(),
        EmailNotificationActive: ko.observable(),
        RegistrationDate: ko.observable(),
    }
    self.error = ko.observable();

    var user_accountsUri = '/api/user_account/';

    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllUserAccounts() {
        ajaxHelper(user_accountsUri, 'GET').done(function (data) {
            self.user_accounts(data);
        });
    }

    self.registerUser = function (formElement) {

        var user = {
            user_type_id: 1,
            email: self.newUser.Email,
            password: self.newUser.Password,
            date_of_birth: self.newUser.DateOfBirth,
            gender: self.newUser.Gender,
            is_active: 1,
            contact_number: self.newUser.ContactNumber,
            sms_notification_active: 0,
            email_notification_active: 0,
            registration_date: new Date(),
        };

        ajaxHelper(user_accountsUri, 'POST', user).done(function (item) {
            self.user_accounts.push(item);
        });
    }

    // Fetch the initial data.
    getAllUserAccounts();
};

ko.applyBindings(new ViewModel());