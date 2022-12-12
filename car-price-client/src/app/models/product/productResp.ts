import { paginationReps } from "../abstraction/paginationReps";
import { CarInfo } from "../CarInfo";

export interface productResp extends paginationReps<CarInfo> {}