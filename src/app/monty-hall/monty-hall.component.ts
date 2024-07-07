import { Component, OnInit } from '@angular/core';
import { MontyHallService } from '../shared/monty-hall.service';

@Component({
  selector: 'app-monty-hall',
  templateUrl: './monty-hall.component.html',
  styleUrls: ['./monty-hall.component.scss']
})
export class MontyHallComponent implements OnInit {

  numberOfGames: number = 1;
  changeDoor: boolean = true;
  result: any = null;

  constructor(private montyHallService: MontyHallService) { }

  ngOnInit(): void {
  }

  runSimulation(): void {
    this.montyHallService.simulateGames(this.numberOfGames, this.changeDoor).subscribe(result => {
      this.result = result;
    });
  }
}
