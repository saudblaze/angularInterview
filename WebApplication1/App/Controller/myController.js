myApp.controller("mycontroller", function ($scope, EmployeeService) {
    $scope.Employee = {};
    $scope.DepartmentList = [{
        id: 1,
        name: "HR"
    }, {
        id: 2,
        name: "IT"
    }, {
        id: 3,
        name: "Sales"
    }];

    $scope.GetEmployee = function () {
        EmployeeService.GetEmployeeList().then(function (result) {
            $scope.EmployeeList = result.data;            
        });
    }
    $scope.GetEmployee();

    $scope.SaveEmployee = function () {
        EmployeeService.SaveEmployee($scope.Employee).then(function (result) {
            if (result.data.ErrorNumber == "1") {
                alert("successfully created employee.");
                $scope.Employee = {};
                $scope.GetEmployee();                
            }
        });

    }

    $scope.Cancel = function () {
        $scope.Employee = {};
    }

    $scope.EditEmployee = function (ID) {
        EmployeeService.GetEmployeeByID(ID).then(function (result) {
            if (result.data) {
                $scope.Employee = result.data;
                $scope.Employee.DOB = new Date($scope.Employee.DOB);
            }
            $scope.Employee = result.data;
        });
    }
    $scope.DeleteEmployee = function (ID) {
        EmployeeService.DeleteEmployee(ID).then(function (result) {
            if (result.data.ErrorNumber == "1") {
                alert("successfully deleted employee.");
                $scope.GetEmployee();
            }
            
        });
    }

});