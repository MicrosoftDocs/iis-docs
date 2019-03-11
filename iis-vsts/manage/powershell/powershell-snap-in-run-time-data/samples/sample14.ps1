PS IIS:\AppPools\DefaultAppPool\WorkerProcesses> (get-item 6612).GetRequests(0).Collection | select url,timeElapsed
url                                                                                     timeElapsed
---                                                                                     -----------
/long.aspx                                                                                     2637