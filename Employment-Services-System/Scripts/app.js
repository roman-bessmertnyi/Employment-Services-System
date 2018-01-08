var ViewModel = function () {
    var self = this;
    self.user_accounts = ko.observableArray();
    self.user_types = ko.observableArray();
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
    var user_typesUri = '/api/user_type/';

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

    function getUserTypes() {
        ajaxHelper(user_typesUri, 'GET').done(function (data) {
            self.user_types(data);
        });
    }

    function getAllUserAccounts() {
        ajaxHelper(user_accountsUri, 'GET').done(function (data) {
            self.user_accounts(data);
        });
    }

    self.registerUser = function (formElement) {
        self.newUser.IsActive = 1;
        self.newUser.RegistrationDate = new Date();
        self.newUser.UserType = 1;
        self.newUser.SmsNotificationActive = 0;
        self.newUser.EmailNotificationActive = 0;


        var user = {
            UserTypeId: self.newUser.UserType,
            Email: self.newUser.Email,
            Password: self.newUser.Password,
            DateOfBirth: self.newUser.DateOfBirth,
            Gender: self.newUser.Gender,
            IsActive: self.newUser.IsActive,
            ContactNumber: self.newUser.ContactNumber,
            SmsNotificationActive: self.newUser.SmsNotificationActive,
            EmailNotificationActive: self.newUser.EmailNotificationActive,
            RegistrationDate: self.newUser.RegistrationDate,
        };

        ajaxHelper(user_accountsUri, 'POST', user).done(function (item) {
            self.user_accounts.push(item);
        });
    }

    // Fetch the initial data.
    getAllUserAccounts();
    getUserTypes();
};

ko.applyBindings(new ViewModel());