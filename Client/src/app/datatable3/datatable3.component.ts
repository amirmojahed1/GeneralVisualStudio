import { Component, AfterViewInit, ElementRef, Renderer2, ViewChild} from '@angular/core';
declare var $: any;
// import * as $ from 'jquery';
import $ from '../../../../Client/node_modules/jquery/dist/jquery.js';
import '../../../node_modules/datatables.net';
import '../../../node_modules/datatables.net-dt';


@Component({
  selector: 'app-data-table',
  templateUrl: './datatable3.component.html',
  standalone: false
})


export class Datatable3Component implements AfterViewInit {
  @ViewChild('demoHtmlDiv') demoHtmlDiv!: ElementRef;

  constructor(private renderer: Renderer2) {}

ngAfterViewInit(): void {
  // Set RTL direction on wrapper
  this.renderer.setAttribute(this.demoHtmlDiv.nativeElement, 'dir', 'rtl');
  setTimeout(() => {
    // Initialize DataTable
    const table = ($('#example') as any).DataTable({
      paging: true,            // Enable pagination
      ordering: true,          // Enable sorting
      info: true,              // Show information text (e.g. "Showing 1 to 10 of 50 entries")
      searching: true,         // Enable search (filtering)
      lengthChange: true,      // Allow users to change number of rows per page
      pageLength: 10,          // Default rows per page
      scrollX: true,           // Enable horizontal scrolling
      scrollY: '300px',        // Vertical scrolling
      scrollCollapse: true,    // Collapse table when there are fewer rows than the height of the scroll
      fixedHeader: true,       // Keep header fixed on scroll
      dom: '<"top"ip>rt<"bottom"l><"clear">',           // Customize the placement of table features (search, pagination, etc.)
      language: {
        url: 'https://cdn.datatables.net/plug-ins/1.10.22/i18n/Persian.json' // Example for Persian (RTL)
      },
      initComplete: function () {
        this.api()
          .columns()
          .every(function () {
            const column = this;
            // Use the second row (search row) for input events
            $('input', this.header()).on('keyup change clear', function () {
              if (column.search() !== this['value']) {
                column.search(this['value']).draw();
              }
            });
          });
      }
    });
  }, 0); // Timeout to wait for view initialization
}
}