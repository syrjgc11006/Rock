﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PersonRegistrationsList.ascx.cs" Inherits="RockWeb.Blocks.Event.PersonRegistrationsList" %>

<asp:UpdatePanel ID="upMain" runat="server">
    <ContentTemplate>

        <Rock:NotificationBox ID="nbBlockStatus" runat="server" NotificationBoxType="Info" />

        <asp:Panel ID="pnlContent" runat="server">

            <div id="pnlRegistrations" runat="server">

                <div class="panel panel-block">

                    <div class="panel-heading clearfix">
                        <h1 class="panel-title pull-left">
                            <i class="fa fa-users"></i>
                            <asp:Literal ID="lHeading" runat="server" />
                        </h1>
                    </div>

                    <div class="panel-body">
                        <Rock:ModalAlert ID="mdGridWarning" runat="server" />

                        <div class="grid grid-panel">
                            <Rock:GridFilter ID="rFilter" runat="server" OnDisplayFilterValue="rFilter_DisplayFilterValue" OnClearFilterClick="rFilter_ClearFilterClick" FieldLayout="Custom">
                                <div class="row">
                                    <div class="col-lg-6">
                                        <Rock:DateRangePicker ID="drpFilterDate" runat="server" Label="Date" />
                                    </div>
                                </div>
                            </Rock:GridFilter>
                            <Rock:Grid ID="gRegistrations" runat="server" AllowSorting="true" OnRowSelected="gRegistrations_Edit" OnRowDataBound="gRegistrations_RowDataBound" ExportSource="ColumnOutput" >
                                <Columns>
                                    <Rock:RockLiteralField ID="lExportFullName" HeaderText="Name" Visible="false" ExcelExportBehavior="AlwaysInclude" />
                                    <Rock:RockLiteralField ID="lNameWithHtml" HeaderText="Name" SortExpression="LastName,NickName" ExcelExportBehavior="NeverInclude" />
                                    <Rock:RockLiteralField ID="lBiStateGraph" HeaderText="Recent Engagement" ExcelExportBehavior="NeverInclude" />
                                    <Rock:RockBoundField DataField="CurrentStreakCount" HeaderText="Current Streak" SortExpression="CurrentStreakCount" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right" />
                                    <Rock:RockBoundField DataField="LongestStreakCount" HeaderText="Longest Streak" SortExpression="LongestStreakCount" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right" />
                                    <Rock:RockBoundField DataField="EngagementCount" HeaderText="Engagements" SortExpression="EngagementCount" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right" />
                                    <Rock:DateTimeField HeaderText="Enrollment Date" DataField="EnrollmentDate" SortExpression="EnrollmentDate" DataFormatString="{0:d}" />
                                </Columns>
                            </Rock:Grid>
                        </div>
                    </div>
                </div>
            </div>

             <script>

                Sys.Application.add_load( function () {
                    $("div.photo-icon").lazyload({
                        effect: "fadeIn"
                    });

                    // person-link-popover
                    $('.js-person-popover').popover({
                        placement: 'right',
                        trigger: 'manual',
                        delay: 500,
                        html: true,
                        content: function() {
                            var dataUrl = Rock.settings.get('baseUrl') + 'api/People/PopupHtml/' +  $(this).attr('personid') + '/false';

                            var result = $.ajax({
                                                type: 'GET',
                                                url: dataUrl,
                                                dataType: 'json',
                                                contentType: 'application/json; charset=utf-8',
                                                async: false }).responseText;

                            var resultObject = jQuery.parseJSON(result);

                            return resultObject.PickerItemDetailsHtml;

                        }
                    }).on('mouseenter', function () {
                        var _this = this;
                        $(this).popover('show');
                        $(this).siblings('.popover').on('mouseleave', function () {
                            $(_this).popover('hide');
                        });
                    }).on('mouseleave', function () {
                        var _this = this;
                        setTimeout(function () {
                            if (!$('.popover:hover').length) {
                                $(_this).popover('hide')
                            }
                        }, 100);
                    });

                });
            </script>

        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>
