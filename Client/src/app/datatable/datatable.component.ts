import { Component, AfterViewInit, ElementRef, Renderer2, ViewChild } from '@angular/core';
declare var $: any;

@Component({
  selector: 'app-data-table',
  templateUrl: './datatable.component.html',
  standalone: false,
})
export class DataTableComponent implements AfterViewInit {
  @ViewChild('demoHtmlDiv') demoHtmlDiv!: ElementRef;

  constructor(private renderer: Renderer2) {}

  ngAfterViewInit() {
    this.renderer.setAttribute(this.demoHtmlDiv.nativeElement, 'dir', 'rtl');

    // Add second header row with empty cells BEFORE DataTable init
    const $thead = $('#example thead');
    if ($thead.find('tr').length === 2) {
      const $secondHeaderRow = $('<tr>');
      $thead.find('tr:eq(0) th').each(function () {
        $secondHeaderRow.append('<th></th>');
      });
      $thead.append($secondHeaderRow);
    }

    setTimeout(() => {
      const table = ($('#example') as any).DataTable({
        orderCellsTop: true,
        // dom: '<"top"ip>rt<"bottom"l><"clear">',
            // Customize the placement of table features (search, pagination, etc.)
        language: {
          url: '../../assets/urls/Persian.json'
        },
        initComplete: function () {
          const api = this.api();

          // Add text input to every column header's filter cell
          $('#example thead tr:eq(2) th').each(function (index) {
            const column = api.column(index);
            $(this).html('<input type="text" placeholder="Search" style="width: 100%;" />');

            $('input', this).on('keyup change clear', function () {
              if (column.search() !== this.value) {
                column.search(this.value).draw();
              }
            });
          });
        }
      });
    }, 0);
  }

}
