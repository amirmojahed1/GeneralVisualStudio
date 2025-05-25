import { Component, OnInit, AfterViewInit, ElementRef, Renderer2, ViewChild } from '@angular/core';
declare var $: any;

@Component({
  selector: 'app-datatable2',
  templateUrl: './datatable2.component.html',
  standalone:false,
})
export class Datatable2Component implements OnInit, AfterViewInit {
  @ViewChild('demoHtmlDiv') demoHtmlDiv!: ElementRef;
  isFarsi: boolean = true;

  constructor(private renderer: Renderer2) {}

  ngOnInit(): void {
    // ✅ Set default direction when the component initializes
    this.renderer.setAttribute(this.demoHtmlDiv.nativeElement, 'dir', 'rtl');
  }

  toggleLanguage(): void {
    this.isFarsi = !this.isFarsi;
    const direction = this.isFarsi ? 'rtl' : 'ltr';
    this.renderer.setAttribute(this.demoHtmlDiv.nativeElement, 'dir', direction);

    // ✅ Destroy and reinitialize DataTable with the correct language
    this.reinitializeDataTable();
  }

  ngAfterViewInit(): void {
    this.reinitializeDataTable();
  }

  reinitializeDataTable(): void {
    const $table = $('#example');

    // ✅ Destroy existing DataTable instance before reinitializing
    // if ($.fn.DataTable.isDataTable('#example')) {
    //   $table.DataTable().destroy();
    //   $table.find('thead tr:eq(2) th input').off();
      // Remove previous event listeners
    // }

    // ✅ Ensure header rows are added BEFORE DataTable init
    // const $thead = $('#example thead');
    // if ($thead.find('tr').length === 1) {
    //   const $secondHeaderRow = $('<tr>');
    //   $thead.find('tr:eq(0) th').each(function () {
    //     $secondHeaderRow.append('<th></th>');
    //   });
    //   $thead.append($secondHeaderRow);
    // }

    setTimeout(() => {
      $table.DataTable({
        orderCellsTop: true,
        language: { url: this.isFarsi ? '../../assets/urls/Persian.json' : '../../assets/urls/English.json' },
        initComplete: function () {
          const api = this.api();

          // ✅ Add search inputs to the third header row, skipping first and last columns
          $('#example thead tr:eq(2) th').each(function (index) {
            if (index !== 0 && index !== $('#example thead tr:eq(0) th').length - 1) {
              const column = api.column(index);
              $(this).html('<input type="text" placeholder="Search" style="width: 100%;" />');

              $('input', this).on('keyup change clear', function () {
                if (column.search() !== this.value) {
                  column.search(this.value).draw();
                }
              });
            }
          });
        }
      });
    }, 0);
  }
}
