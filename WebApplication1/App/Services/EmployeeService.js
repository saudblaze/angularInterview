myApp.service("EmployeeService", function ($http) {

    this.SaveEmployee = function (EmployeeDetails) {
        debugger;
        var request = $http({
            method: "post",
            url: url + "/api/Employee/SaveEmployee/",
            data: EmployeeDetails
        });
        return request;

    }

    this.GetEmployeeList = function () {
        var request = $http({
            method: "get",
            url: url + "/api/Employee/GetEmployeeList/",            
        });
        return request;

    }

    this.GetEmployeeByID = function (ID) {
        var request = $http({
            method: "get",
            url: url + "/api/Employee/GetEmployeeByID?ID=" + ID,
        });
        return request;

    }
    this.DeleteEmployee = function (ID) {
        var request = $http({
            method: "get",
            url: url + "/api/Employee/DeleteEmployee?ID=" + ID,
        });
        return request;

    }
})