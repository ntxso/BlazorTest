window.auth = {
    setToken: function (token) {
        localStorage.setItem('fakeAuthToken', token);
    },
    getToken: function () {
        return localStorage.getItem('fakeAuthToken');
    },
    removeToken: function () {
        localStorage.removeItem('fakeAuthToken');
    }
};
