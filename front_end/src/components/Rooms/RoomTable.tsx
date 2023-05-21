import { useState } from "react";
import {
  createStyles,
  Table,
  ScrollArea,
  UnstyledButton,
  Group,
  Text,
  Center,
  TextInput,
  rem,
} from "@mantine/core";
import { keys } from "@mantine/utils";
import {
  IconSelector,
  IconChevronDown,
  IconChevronUp,
  IconSearch,
} from "@tabler/icons-react";
import { Room } from "../../models/types";

const useStyles = createStyles((theme) => ({
  th: {
    padding: "0 !important",
  },

  control: {
    width: "100%",
    padding: `${theme.spacing.xs} ${theme.spacing.md}`,

    "&:hover": {
      backgroundColor:
        theme.colorScheme === "dark"
          ? theme.colors.dark[6]
          : theme.colors.gray[0],
    },
  },

  icon: {
    width: rem(21),
    height: rem(21),
    borderRadius: rem(21),
  },
}));
interface TableSortProps {
  data: Room[];
  displaySearchBar?: boolean;
}

interface ThProps {
  children: React.ReactNode;
  reversed: boolean;
  sorted: boolean;
  onSort(): void;
}

function Th({ children, reversed, sorted, onSort }: ThProps) {
  const { classes } = useStyles();
  const Icon = sorted
    ? reversed
      ? IconChevronUp
      : IconChevronDown
    : IconSelector;
  return (
    <th className={classes.th}>
      <UnstyledButton onClick={onSort} className={classes.control}>
        <Group position="apart">
          <Text fw={500} fz="sm">
            {children}
          </Text>
          <Center className={classes.icon}>
            <Icon size="0.9rem" stroke={1.5} />
          </Center>
        </Group>
      </UnstyledButton>
    </th>
  );
}

const filterData = (data: Room[], query: string) => {
  const keysToFilter = keys(data[0]);
  return data

    .filter((item) =>
      keysToFilter.some((key) =>
        String(item[key])
          .toLowerCase()
          .trim()
          .includes(query.toLowerCase().trim())
      )
    )
    .sort((a, b) => a.Name.localeCompare(b.Name))
    .reverse();
};

const sortData = (
  data: Room[],
  {
    sortBy,
    reversed,
    search,
  }: { sortBy: keyof Room | null; reversed: boolean; search: string }
) => {
  const sortedData = sortBy
    ? [...data].sort((a, b) => {
        if (a[sortBy] < b[sortBy]) {
          return reversed ? 1 : -1;
        }
        if (a[sortBy] > b[sortBy]) {
          return reversed ? -1 : 1;
        }
        return 0;
      })
    : data;

  return search ? filterData(sortedData, search) : sortedData;
};

export const RoomTable: React.FC<TableSortProps> = (props) => {
  const { data, displaySearchBar } = props;
  const [search, setSearch] = useState("");
  const [sortedData, setSortedData] = useState<Room[]>(data);
  const [sortBy, setSortBy] = useState<keyof Room | null>(null);
  const [reverseSortDirection, setReverseSortDirection] = useState(false);

  const setSorting = (field: keyof Room) => {
    const reversed = field === sortBy ? !reverseSortDirection : false;
    setReverseSortDirection(reversed);
    setSortBy(field);
    setSortedData(sortData(data, { sortBy: field, reversed, search }));
  };

  const handleSearchChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const { value } = event.currentTarget;
    setSearch(value);
    setSortedData(
      sortData(data, { sortBy, reversed: reverseSortDirection, search: value })
    );
  };
  const rows = sortedData.map((room, index) => (
    <tr key={index}>
      <td>{room.Name}</td>
      <td>{room.PatientNames.length ? room.PatientNames : "Null"}</td>
    </tr>
  ));

  return (
    <ScrollArea>
      {displaySearchBar && (
        <TextInput
          placeholder="Search by any field"
          mb="md"
          icon={<IconSearch size="0.9rem" stroke={1.5} />}
          value={search}
          onChange={handleSearchChange}
        />
      )}

      <Table
        horizontalSpacing="md"
        verticalSpacing="xs"
        miw={700}
        sx={{ tableLayout: "fixed" }}
      >
        <thead>
          <tr>
            <Th
              reversed={reverseSortDirection}
              sorted={sortBy === "Name"}
              onSort={() => setSorting("Name")}
            >
              Room Name
            </Th>
            <Th
              reversed={reverseSortDirection}
              sorted={sortBy === "PatientNames"}
              onSort={() => setSorting("PatientNames")}
            >
              Patients
            </Th>
          </tr>
        </thead>
        <tbody>
          {rows.length > 0 ? (
            rows
          ) : (
            <tr>
              <td colSpan={Object.keys(data[0]).length}>
                <Text weight={500} align="center">
                  Nothing found
                </Text>
              </td>
            </tr>
          )}
        </tbody>
      </Table>
    </ScrollArea>
  );
};
