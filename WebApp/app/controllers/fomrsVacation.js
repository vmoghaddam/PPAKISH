﻿'use strict';
app.controller('formsVacationController', ['$scope', '$location', '$routeParams', '$rootScope', 'flightService', 'authService', '$route', function ($scope, $location, $routeParams, $rootScope, flightService, authService, $route) {
    
    $scope.caption = 'Requests';
    $scope.url = 'api/vacation/forms/all';
    //////////////////////////////////
    $scope.dsUrl = null;
    $scope.filterVisible = false;
    $scope.btn_delete = {
        text: 'Delete',
        type: 'danger',
        icon: 'clear',
        width: 120,

        onClick: function (e) {
            $scope.dg_selected = $rootScope.getSelectedRow($scope.dg_instance);
            if (!$scope.dg_selected) {
                General.ShowNotify(Config.Text_NoRowSelected, 'error');
                return;
            }

            General.Confirm(Config.Text_DeleteConfirm, function (res) {
                if (res) {

                    var dto = { Id: $scope.dg_selected.Id, };
                    $scope.loadingVisible = true;
                    organizationService.delete(dto).then(function (response) {
                        $scope.loadingVisible = false;
                        General.ShowNotify(Config.Text_SavedOk, 'success');
                        $scope.doRefresh = true;
                        $scope.bind();



                    }, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });

                }
            });
        }
    };
    $scope.btn_new = {
        text: 'View',
        type: 'default',
        
        width: 120,
        onClick: function (e) {
            $scope.dg_selected = $rootScope.getSelectedRow($scope.dg_instance);
            if (!$scope.dg_selected) {
                General.ShowNotify(Config.Text_NoRowSelected, 'error');
                return;
            }
            $scope.entity = JSON.parse( JSON.stringify($scope.dg_selected));
            $scope.popup_newform_visible = true;
        }

    };
    $scope.btn_edit = {
        text: 'Edit',
        type: 'default',
        icon: 'edit',
        width: 120,

        onClick: function (e) {
            $scope.dg_selected = $rootScope.getSelectedRow($scope.dg_instance);
            if (!$scope.dg_selected) {
                General.ShowNotify(Config.Text_NoRowSelected, 'error');
                return;
            }
            var data = $scope.dg_selected;
            data._tid = $scope.TypeId;
            $rootScope.$broadcast('InitAddOrganization', data);
        }

    };
    $scope.btn_view = {
        text: 'View',
        type: 'default',
        icon: 'doc',
        width: 120,
        onClick: function (e) {
            $scope.dg_selected = $rootScope.getSelectedRow($scope.dg_instance);
            if (!$scope.dg_selected) {
                General.ShowNotify(Config.Text_NoRowSelected, 'error');
                return;
            }
            var data = $scope.dg_selected;
            $scope.InitAddAirport(data);
        }

    };
    $scope.btn_search = {
        text: 'Search',
        type: 'success',
        icon: 'search',
        width: 120,

        bindingOptions: {},
        onClick: function (e) {

          //  $scope.$broadcast('getFilterQuery', null);
            $scope.dg_ds = null;
            $scope.bind();
        }

    };
    $scope.btn_print = {
        text: 'Print',
        type: 'default',
        icon: 'print',
        width: 120,

    };
    $scope.btn_filter = {
        text: '',
        type: 'default',
        icon: 'filter',
        width: 40,
        onClick: function (e) {
            if ($scope.filterVisible) {
                $scope.filterVisible = false;
                $('.filter').fadeOut();
            }
            else {
                $scope.filterVisible = true;
                $('.filter').fadeIn();
            }
        }

    };
    //////////////////////////////////
    $scope.loadingVisible = false;
    $scope.loadPanel = {
        message: 'Please wait...',

        showIndicator: true,
        showPane: true,
        shading: true,
        closeOnOutsideClick: false,
        shadingColor: "rgba(0,0,0,0.4)",
        // position: { of: "body" },
        onShown: function () {

        },
        onHidden: function () {

        },
        bindingOptions: {
            visible: 'loadingVisible'
        }
    };
    ///////////////////////////////////

    ///////////////////////////////////
    $scope.filters = [];

    $scope.dg_columns_publisher = [
        {
            cellTemplate: function (container, options) {
                $("<div style='text-align:center'/>")
                    .html(options.rowIndex + 1)
                    .appendTo(container);
            }, caption: '#', width: 60, fixed: true, fixedPosition: 'left', allowResizing: false, cssClass: 'rowHeader'
        },
        { dataField: 'DateCreate', caption: 'Date', allowResizing: true, alignment: 'center', dataType: 'datetime', allowEditing: false, width: 120, format: 'yy-MMM-dd', sortIndex: 0, sortOrder: 'desc', fixed: true, fixedPosition: 'left' },
        { dataField: 'ReasonStr', caption: 'Type', allowResizing: true, alignment: 'center', dataType: 'string', allowEditing: false, width: 150 },
        { dataField: 'JobGroup', caption: 'Group', allowResizing: true, alignment: 'center', dataType: 'string', allowEditing: false, width: 150 },
        { dataField: 'Name', caption: 'Name', allowResizing: true, alignment: 'center', dataType: 'string', allowEditing: false, width: 250 },
        { dataField: 'DateFrom', caption: 'From', allowResizing: true, alignment: 'center', dataType: 'datetime', allowEditing: false, width: 120, format: 'yy-MMM-dd', },
        { dataField: 'DateTo', caption: 'To', allowResizing: true, alignment: 'center', dataType: 'datetime', allowEditing: false, width: 120, format: 'yy-MMM-dd', },
       
        { dataField: 'Remark', caption: 'Remark', allowResizing: true, alignment: 'left', dataType: 'string', allowEditing: false, minWidth:350  },
        { dataField: 'OperationRemak', caption: 'Ops. Remark', allowResizing: true, alignment: 'left', dataType: 'string', allowEditing: false, minWidth: 350,   },
        { dataField: 'Status', caption: 'Status', allowResizing: true, alignment: 'center', dataType: 'string', allowEditing: false, width: 120, fixed: true, fixedPosition: 'right' },
        { dataField: 'DateStatus', caption: '', allowResizing: true, alignment: 'center', dataType: 'datetime', allowEditing: false, width: 120, format: 'yy-MMM-dd',  fixed: true, fixedPosition: 'right' },
    ];
    $scope.dg_columns = [];
    $scope.dg_columns = $scope.dg_columns_publisher;

    $scope.dg_selected = null;
    $scope.dg_instance = null;
    $scope.dg_ds = null;
    $scope.dg = {
        headerFilter: {
            visible: false
        },
        filterRow: {
            visible: true,
            showOperationChooser: true,
        },
        showRowLines: true,
        showColumnLines: true,
        sorting: { mode: 'none' },

        noDataText: '',

        allowColumnReordering: true,
        allowColumnResizing: true,
        scrolling: { mode: 'infinite' },
        paging: { pageSize: 100 },
        showBorders: true,
        selection: { mode: 'single' },

        columnAutoWidth: false,
        height: $(window).height() - 135,

        columns: $scope.dg_columns,
        onContentReady: function (e) {
            if (!$scope.dg_instance)
                $scope.dg_instance = e.component;

        },
        onSelectionChanged: function (e) {
            var data = e.selectedRowsData[0];

            if (!data) {
                $scope.dg_selected = null;
            }
            else
                $scope.dg_selected = data;


        },
        onCellPrepared: function (e) {
            if (e.rowType === "data" && e.column.dataField == "Status") {
                $scope.styleCell(e, e.data.Status);
            }
        },
        bindingOptions: {
            dataSource: 'dg_ds'
        }
    };

    $scope.styleCell = function (e, value) {
        if (!value  ) {
            
            e.cellElement.css("backgroundColor", "#a6a6a6");
            e.cellElement.css("color", "#fff");
            return;
        }
        if (value > 45)
            return;
        //moradi2

        
        if (value=='Accepted') {
            e.cellElement.css("backgroundColor", "#00e6ac");
            e.cellElement.css("color", "#000");
        }
        else   {
            e.cellElement.css("backgroundColor", "#ff9966");
            e.cellElement.css("color", "#000");
        }
        
    }
    $scope.doRefresh = false;

    $scope.getFilters = function () {
        var filters = $scope.filters;
        if (filters.length == 0)
            filters = [['Id', '>', 0]];
        else {
            //filters.push('and');
            //filters.push(['OfficeCode', 'startswith', $scope.ParentLocation.FullCode]);

        }


        return filters;
    };
    $scope.bind = function () {
        
      
            $scope.dg_ds = {
                store: {
                    type: "odata",
                    url: serviceForms + $scope.url,
                    key: "Id",
                    version: 4,
                    onLoaded: function (e) {
                        // $scope.loadingVisible = false;
                        //filter
                        $rootScope.$broadcast('OnDataLoaded', null);
                    },
                    beforeSend: function (e) {

                        $scope.dsUrl = General.getDsUrl(e);

                        // $scope.$apply(function () {
                        //    $scope.loadingVisible = true;
                        // });
                        $rootScope.$broadcast('OnDataLoading', null);
                    },
                },
                // filter: [['OfficeCode', 'startswith', $scope.ParentLocation.FullCode]],
               // sort: ['Title'],

            };
       
        $scope.dg_instance.refresh();
        //if ($scope.doRefresh) {
        //    $scope.filters = $scope.getFilters();
        //    $scope.dg_ds.filter = $scope.filters;
        //    $scope.dg_instance.refresh();
        //    $scope.doRefresh = false;
        //}

    };
    /////////////////////////////
    $scope.dt_from = new Date();
    $scope.date_from = {
        type: "date",
        width: '100%',
        readOnly: true,
        pickerType: "rollers",
        displayFormat: "yyyy-MMM-dd",

        onValueChanged: function (arg) {

        },
        bindingOptions: {
            value: 'entity.DateFrom',

        }
    };
    $scope.dt_to = new Date();
    $scope.date_to = {
        type: "date",
        width: '100%',
        readOnly: true,
        pickerType: "rollers",
        displayFormat: "yyyy-MMM-dd",

        onValueChanged: function (arg) {

        },
        bindingOptions: {
            value: 'entity.DateTo',

        }
    };
    $scope.reasons = [
        { id: 1, title: 'Vacation' },
        { id: 2, title: 'Medical Care' },
        { id: 3, title: 'Other' },
    ];
    $scope.statusds = [
        { id: 1, title: 'Accepted' },
        { id: 2, title: 'Rejected' },
        
    ];

    $scope.reason = 'Vacation';
    $scope.sb_reason = {
        showClearButton: false,
        searchEnabled: false,
        dataSource: $scope.reasons,
        displayExpr: 'title',
        placeholder: '',
        valueExpr: 'id',
        readOnly: true,
        bindingOptions: {
            value: 'entity.Reason'

        }
    };
    $scope.sb_status = {
        showClearButton: false,
        searchEnabled: false,
        dataSource: $scope.statusds,
        displayExpr: 'title',
        placeholder: '',
        valueExpr: 'title',
       
        bindingOptions: {
            value: 'entity.Status'

        }
    };

    $scope.remark = '';
    $scope.txt_remark = {
        readOnly: true,
        rtlEnabled:true,
        bindingOptions: {
            value: 'entity.Remark',
            height: '170',

        }
    };
    $scope.txt_remarkops = {
         
        bindingOptions: {
            value: 'entity.OperationRemak',
            height: '320',

        }
    };
    $scope.txt_name = {
        readOnly: true,
        bindingOptions: {
            value: 'entity.Name',
            

        }
    };
    $scope.txt_group = {
        readOnly: true,
        bindingOptions: {
            value: 'entity.JobGroup',
 
        }
    };
    $scope.txt_mobile = {
        readOnly: true,
        bindingOptions: {
            value: 'entity.Mobile',


        }
    };
    $scope.txt_pid = {
        readOnly: true,
        bindingOptions: {
            value: 'entity.PID',


        }
    };
    $scope.date_create = {
        type: "date",
        width: '100%',
        pickerType: "rollers",
        displayFormat: "yyyy-MMM-dd",
        readOnly:true,
        onValueChanged: function (arg) {

        },
        bindingOptions: {
            value: 'entity.DateCreate',

        }
    };
    $scope.popup_newform_visible = false;
    $scope.popup_newform = {
        height: 610,
        width: 850,
        title: 'Form',
        showTitle: true,

        toolbarItems: [



            {
                widget: 'dxButton', location: 'after', options: {
                    type: 'default', text: 'Save', validationGroup: 'formvacupd', onClick: function (e) {
                        var result = e.validationGroup.validate();

                        if (!result.isValid) {
                            General.ShowNotify(Config.Text_FillRequired, 'error');
                            return;
                        }

                       
                        var dto = {
                            Id: $scope.entity.Id,
                            UserId: $scope.entity.UserId,
                            DateFrom: new Date($scope.entity.DateFrom),
                            DateTo: new Date($scope.entity.DateTo),
                            ReasonStr: $scope.entity.ReasonStr,
                            Reason: $scope.entity.Reason,
                            Remark: $scope.entity.Remark,
                            OperationRemak: $scope.entity.OperationRemak,
                            Status: $scope.entity.Status,
                            OperatorId: $scope.entity.OperatorId,
                        };
                        $scope.loadingVisible = true;
                        flightService.updateFormVacation(dto).then(function (response) {
                            $scope.loadingVisible = false;

                            $scope.dg_selected = response;
                          
                            $scope.popup_newform_visible = false;

                        }, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });

                    }
                }, toolbar: 'bottom'
            },
            {
                widget: 'dxButton', location: 'after', options: {
                    type: 'danger', text: 'Close', icon: 'remove', onClick: function (e) {
                        $scope.popup_newform_visible = false;
                    }
                }, toolbar: 'bottom'
            }

        ],

        visible: false,
        dragEnabled: true,
        closeOnOutsideClick: false,
        onShowing: function (e) {

        },
        onShown: function (e) {

        },
        onHiding: function () {

            //$scope.clearEntity();
            $scope.dg_instance.refresh();
            $scope.popup_newform_visible = false;

        },
        onContentReady: function (e) {

        },
        bindingOptions: {
            visible: 'popup_newform_visible',


        }
    };
    ///////////////////////
    if (!authService.isAuthorized()) {

        authService.redirectToLogin();
    }
    else {
        $rootScope.page_title = '> ' + $scope.caption;
        $('.vacations').fadeIn();
    }
    //////////////////////////////////////////
    $scope.$on('getFilterResponse', function (event, prms) {

        $scope.filters = prms;

        $scope.doRefresh = true;
        $scope.bind();
    });
    $scope.$on('onTemplateSearch', function (event, prms) {

        $scope.$broadcast('getFilterQuery', null);
    });
    $scope.$on('onOrganizationSaved', function (event, prms) {

        $scope.doRefresh = true;
    });
    $scope.$on('onOrganizationHide', function (event, prms) {

        $scope.bind();

    });
    //////////////////////////////////////////
    $rootScope.$broadcast('OrganizationLoaded', null);
    ///end
}]);