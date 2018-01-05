var ViewModel = function () {
    var self = this;
    self.user_accounts = ko.observableArray();
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

    // Fetch the initial data.
    getAllUserAccounts();
};

ko.applyBindings(new ViewModel());